#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#endregion

/// <remarks>
///    File Copier - Windows Forms demonstration program
///    (c) Copyright 2005 Liberty Associates, Inc.
/// </remarks>
namespace FileCopier
{


   /// <summary>
   /// Form demonstrating Windows Forms implementation
   /// </summary>
   partial class frmFileCopier : Form
   {
      private const int MaxLevel = 2;
      public frmFileCopier()
      {
         InitializeComponent();
         FillDirectoryTree( tvwSource, true );
         FillDirectoryTree( tvwTarget, false );
      }

      /// <summary>
      ///    nested class which knows how to compare 
      ///    two files we want to sort large to small, 
      ///    so reverse the normal return values.
      /// </summary>
      public class FileComparer : IComparer<FileInfo>
      {


		  public int Compare(FileInfo file1, FileInfo file2)
		  {

			if ( file1.Length > file2.Length )
            {
               return -1;
            }
            if ( file1.Length < file2.Length )
            {
               return 1;
            }
            return 0;
         }

		  public bool Equals(FileInfo x, FileInfo y) { throw new NotImplementedException(); }
		  public int GetHashCode(FileInfo x) {throw new NotImplementedException(); }

	  }



      private void FillDirectoryTree( TreeView tvw, bool isSource )
      {
         //  Populate tvwSource, the Source TreeView, 
         //  with the contents of 
         //  the local hard drive.
         //  First clear all the nodes.
         tvw.Nodes.Clear();

         //  Get the logical drives and put them into the
         //  root nodes. Fill an array with all the
         // logical drives on the machine.
         string[] strDrives = Environment.GetLogicalDrives();

         //  Iterate through the drives, adding them to the tree.
         //  Use a try/catch block, so if a drive is not ready, 
         //  e.g. an empty floppy or CD,
         //    it will not be added to the tree.
         foreach ( string rootDirectoryName in strDrives )
         {

            try
            {

               //  Fill an array with all the first level 
               //  subdirectories. If the drive is
               //  not ready, this will throw an exception.
               DirectoryInfo dir =
                   new DirectoryInfo( rootDirectoryName );

               dir.GetDirectories();      // force exception if drive not ready

               TreeNode ndRoot = new TreeNode( rootDirectoryName );

               //  Add a node for each root directory.
               tvw.Nodes.Add( ndRoot );

               //  Add subdirectory nodes.
               //  If Treeview is the source, 
               //  then also get the filenames.
               if ( isSource )
               {
                  
                  GetSubDirectoryNodes(
                    ndRoot, ndRoot.Text, true,1 );
               }
               else
               {
                  GetSubDirectoryNodes(
                    ndRoot, ndRoot.Text, false,1 );
               }
            }
            //  Catch any errors such as 
               // Drive not ready.
            catch 
            {
            }
            Application.DoEvents();
         }
      } //  close for FillSourceDirectoryTree

      /// <summary>
      /// Gets all the subdirectories below the 
      /// passed in directory node.
      /// Adds to the directory tree.
      /// The parameters passed in are the parent node 
      /// for this subdirectory,
      /// the full path name of this subdirectory, 
      /// and a Boolean to indicate
      /// whether or not to get the files in the subdirectory.
      /// </summary>
      private void GetSubDirectoryNodes(
          TreeNode parentNode, string fullName, bool getFileNames, int level )
      {



         DirectoryInfo dir = new DirectoryInfo( fullName );
         DirectoryInfo[] dirSubs = dir.GetDirectories();

         //  Add a child node for each subdirectory.
         foreach ( DirectoryInfo dirSub in dirSubs )
         {

            // do not show hidden folders
            if ( ( dirSub.Attributes & FileAttributes.Hidden )
               != 0 )
            {
               continue;
            }

            /// <summary>
            ///    Each directory contains the full path.
            ///    We need to split it on the backslashes, 
            ///    and only use
            ///    the last node in the tree.
            ///    Need to double the backslash since it 
            ///    is normally 
            ///    an escape character
            /// </summary>
            TreeNode subNode = new TreeNode( dirSub.Name );
            parentNode.Nodes.Add( subNode );

            //  Call GetSubDirectoryNodes recursively.

            if ( level < MaxLevel )
            {
               GetSubDirectoryNodes(
                 subNode, dirSub.FullName, getFileNames, level+1 );
            }

         }
         if ( getFileNames )
         {
            //  Get any files for this node.
            FileInfo[] files = dir.GetFiles();

            // After placing the nodes, 
            // now place the files in that subdirectory.
            foreach ( FileInfo file in files )
            {
               TreeNode fileNode = new TreeNode( file.Name );
               parentNode.Nodes.Add( fileNode );
            }
         }
      }

 
      /// <summary>
      ///    Create an ordered list of all 
      ///    the selected files, copy to the
      ///    target directory
      /// </summary>
      private void btnCopy_Click( object sender,
          System.EventArgs e )
      {
         // get the list
         List<FileInfo> fileList = GetFileList();

         // copy the files
         foreach ( FileInfo file in fileList )
         {
            try
            {
               // update the label to show progress
               lblStatus.Text = "Copying " + txtTargetDir.Text +
                   "\\" + file.Name + "...";
               Application.DoEvents();

               // copy the file to its destination location
               file.CopyTo( txtTargetDir.Text + "\\" +
                   file.Name, chkOverwrite.Checked );
            }

            catch ( Exception ex )
            {
               // you may want to do more than 
               // just show the message
               MessageBox.Show( ex.Message );
            }
         }
         lblStatus.Text = "Done.";

      }


      /// <summary>
      ///    Tell the root of each tree to uncheck
      ///    all the nodes below
      /// </summary>
      private void btnClear_Click( object sender, System.EventArgs e )
      {
         // get the top most node for each drive
         // and tell it to clear recursively
         foreach ( TreeNode node in tvwSource.Nodes )
         {
            SetCheck( node, false );
         }
      }

      /// <summary>
      ///    on cancel,  exit
      /// </summary>
      private void btnCancel_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }



  
      /// <summary>
      ///    Given a node and an array list
      ///    fill the list with the names of
      ///    all the checked files
      /// </summary>
      // Fill the ArrayList with the full paths of 
      // all the files checked
      private void GetCheckedFiles( TreeNode node,
          List<string> fileNames )
      {
         // if this is a leaf...
         if ( node.Nodes.Count == 0 )
         {
            // if the node was checked...
            if ( node.Checked )
            {
               // get the full path and add it to the arrayList
               string fullPath = GetParentString( node );
               fileNames.Add( fullPath );
            }
         }
         else  // if this node is not a leaf
         {
            // if this node is not a leaf
            foreach ( TreeNode n in node.Nodes )
            {
               GetCheckedFiles( n, fileNames );
            }
         }
      }

      /// <summary>
      ///    Given a node, return the
      ///    full path name
      /// </summary>
      private string GetParentString( TreeNode node )
      {
         // if this is the root node (c:\) return the text
         if ( node.Parent == null )
         {
            return node.Text;
         }
         else
         {
            // recurse up and get the path then 
            // add this node and a slash
            // if this node is the leaf, don't add the slash
            return GetParentString( node.Parent ) + node.Text +
                ( node.Nodes.Count == 0 ? "" : "\\" );
         }
      }

      /// <summary>
      ///    shared by delete and copy
      ///    creates an ordered list of all 
      ///    the selected files
      /// </summary>
      private List<FileInfo> GetFileList()
      {
         // create an unsorted array list of the full file names
		  List<string> fileNames = new List<string>();

         // ArrayList fileNames = new ArrayList();

         // fill the fileNames ArrayList with the 
         // full path of each file to copy
         foreach ( TreeNode theNode in tvwSource.Nodes )
         {
            GetCheckedFiles( theNode, fileNames );
         }

         // Create a list to hold the FileInfo objects
         List<FileInfo> fileList = new List<FileInfo>();
		  // ArrayList fileList = new ArrayList();

         // for each of the file names we have in our unsorted list
         // if the name corresponds to a file (and not a directory)
         // add it to the file list
         foreach ( string fileName in fileNames )
         {
            // create a file with the name
            FileInfo file = new FileInfo( fileName );

            // see if it exists on the disk
            // this fails if it was a directory
            if ( file.Exists )
            {
               // both the key and the value are the file
               // would it be easier to have an empty value?
               fileList.Add( file );
            }
         }

         // Create an instance of the IComparer interface
         IComparer<FileInfo> comparer = ( IComparer<FileInfo> ) new FileComparer();

         // pass the comparer to the sort method so that the list
         // is sorted by the compare method of comparer.
         fileList.Sort( comparer );
         return fileList;
      }

      /// <summary>
      ///    check that the user does want to delete
      ///    Make a list and delete each in turn
      /// </summary>
      private void btnDelete_Click( object sender, System.EventArgs e )
      {
         // ask them if they are sure
         System.Windows.Forms.DialogResult result =
             MessageBox.Show(
             "Are you quite sure?",             // msg
            "Delete Files",                    // caption
            MessageBoxButtons.OKCancel,        // buttons
            MessageBoxIcon.Exclamation,        // icons
            MessageBoxDefaultButton.Button2 );  // default button

         // if they are sure...
         if ( result == System.Windows.Forms.DialogResult.OK )
         {
            // iterate through the list and delete them.
            // get the list of selected files
			 List<FileInfo> fileNames = GetFileList();

			 foreach ( FileInfo file in fileNames )
            {
               try
               {
                  // update the label to show progress
                  lblStatus.Text = "Deleting " +
                      txtTargetDir.Text + "\\" +
                      file.Name + "...";
                  Application.DoEvents();

                  // Danger Will Robinson!
                  file.Delete();
               }

               catch ( Exception ex )
               {
                  // you may want to do more than 
                  // just show the message
                  MessageBox.Show( ex.Message );
               }
            }
            lblStatus.Text = "Done.";
            Application.DoEvents();
         }

      }

      /// <summary>
      ///    Get the full path of the chosen directory
      ///    copy it to txtTargetDir
      /// </summary>
      private void tvwTargetDir_AfterSelect(
          object sender,
          System.Windows.Forms.TreeViewEventArgs e )
      {
         // get the full path for the selected directory
         string theFullPath = GetParentString( e.Node );

         // if it is not a leaf, it will end with a back slash
         // remove the backslash
         if ( theFullPath.EndsWith( "\\" ) )
         {
            theFullPath =
                theFullPath.Substring( 0, theFullPath.Length - 1 );
         }
         // insert the path in the text box
         txtTargetDir.Text = theFullPath;
      }

      /// <summary>
      ///    Mark each node below the current
      ///    one with the current value of checked
      /// </summary>
      private void tvwSource_AfterCheck( object sender,
          System.Windows.Forms.TreeViewEventArgs e )
      {
         // Call a recursible method.
         // e.node is the node which was checked by the user.
         // The state of the check mark is already 
         // changed by the time you get here.
         // Therefore, we want to pass along 
         // the state of e.node.Checked.
          SetCheck( e.Node, e.Node.Checked );
      }

      /// <summary>
      ///    recursively set or clear check marks
      /// </summary> 
      private void SetCheck( TreeNode node, bool check )
      {
         // find all the child nodes from this node
         foreach ( TreeNode n in node.Nodes )
         {
            n.Checked = check;   // check the node

            // if this is a node in the tree, recurse
            if ( n.Nodes.Count != 0 )
            {
               SetCheck( n, check );
            }
         }
      }


 

      private void tvwExpand(object sender, TreeViewCancelEventArgs e)
      {

         TreeView tvw = ( TreeView ) sender;
		 bool getFiles = tvw == tvwSource;
		 TreeNode currentNode = e.Node;
         string fullName = currentNode.FullPath;
         currentNode.Nodes.Clear();
         GetSubDirectoryNodes( currentNode, fullName, getFiles, 1 );

      }


   }
}
        