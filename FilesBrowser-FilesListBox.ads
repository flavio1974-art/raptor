-- Autogenerated by MSIL2Ada v. 2
-- By: Martin C. Carlisle
--     Department of Computer Science
--     US Air Force Academy
--     carlislem@acm.org
with MSSyst.Object;
with MSIL_Types;
use MSIL_Types;
limited with FilesBrowser.FileSelectedEventHandler;
limited with FilesBrowser.IconSize;
limited with MSSyst.ComponentModel.CancelEventHandler;
with MSSyst.ComponentModel.Component;
with MSSyst.ComponentModel.IComponent;
limited with MSSyst.ComponentModel.IContainer;
limited with MSSyst.ComponentModel.ISite;
with MSSyst.ComponentModel.ISynchronizeInvoke;
limited with MSSyst.Delegate;
limited with MSSyst.Drawing.Bitmap;
limited with MSSyst.Drawing.Color;
limited with MSSyst.Drawing.Font;
limited with MSSyst.Drawing.Graphics;
limited with MSSyst.Drawing.Image;
limited with MSSyst.Drawing.Point;
limited with MSSyst.Drawing.Rectangle;
limited with MSSyst.Drawing.Region;
limited with MSSyst.Drawing.SizeF;
limited with MSSyst.Drawing.Size;
limited with MSSyst.EventHandler;
limited with MSSyst.IAsyncResult;
with MSSyst.IDisposable;
limited with MSSyst.IFormatProvider;
with MSSyst.MarshalByRefObject;
limited with MSSyst.Runtime.Remoting.ObjRef;
limited with MSSyst.String;
limited with MSSyst.Type_k;
limited with MSSyst.Windows.Forms.AccessibleObject;
limited with MSSyst.Windows.Forms.AccessibleRole;
limited with MSSyst.Windows.Forms.AnchorStyles;
limited with MSSyst.Windows.Forms.BindingContext;
limited with MSSyst.Windows.Forms.BorderStyle;
limited with MSSyst.Windows.Forms.BoundsSpecified;
limited with MSSyst.Windows.Forms.ContextMenuStrip;
limited with MSSyst.Windows.Forms.ContextMenu;
with MSSyst.Windows.Forms.Control;
limited with MSSyst.Windows.Forms.Control.ControlCollection;
limited with MSSyst.Windows.Forms.ControlBindingsCollection;
limited with MSSyst.Windows.Forms.ControlEventHandler;
limited with MSSyst.Windows.Forms.Cursor;
limited with MSSyst.Windows.Forms.DockStyle;
limited with MSSyst.Windows.Forms.DragDropEffects;
limited with MSSyst.Windows.Forms.DragEventHandler;
limited with MSSyst.Windows.Forms.DrawItemEventHandler;
limited with MSSyst.Windows.Forms.DrawMode;
limited with MSSyst.Windows.Forms.Form;
limited with MSSyst.Windows.Forms.GetChildAtPointSkip;
limited with MSSyst.Windows.Forms.GiveFeedbackEventHandler;
limited with MSSyst.Windows.Forms.HelpEventHandler;
with MSSyst.Windows.Forms.IBindableComponent;
limited with MSSyst.Windows.Forms.IContainerControl;
with MSSyst.Windows.Forms.IDropTarget;
with MSSyst.Windows.Forms.IWin32Window;
limited with MSSyst.Windows.Forms.IWindowTarget;
limited with MSSyst.Windows.Forms.ImageLayout;
limited with MSSyst.Windows.Forms.ImeMode;
limited with MSSyst.Windows.Forms.InvalidateEventHandler;
limited with MSSyst.Windows.Forms.KeyEventHandler;
limited with MSSyst.Windows.Forms.KeyPressEventHandler;
limited with MSSyst.Windows.Forms.Layout.LayoutEngine;
limited with MSSyst.Windows.Forms.LayoutEventHandler;
with MSSyst.Windows.Forms.ListBox;
limited with MSSyst.Windows.Forms.ListBox.IntegerCollection;
limited with MSSyst.Windows.Forms.ListBox.ObjectCollection;
limited with MSSyst.Windows.Forms.ListBox.SelectedIndexCollection;
limited with MSSyst.Windows.Forms.ListBox.SelectedObjectCollection;
with MSSyst.Windows.Forms.ListControl;
limited with MSSyst.Windows.Forms.ListControlConvertEventHandler;
limited with MSSyst.Windows.Forms.MeasureItemEventHandler;
with MSSyst.Windows.Forms.Message;
limited with MSSyst.Windows.Forms.MouseEventHandler;
limited with MSSyst.Windows.Forms.Padding;
limited with MSSyst.Windows.Forms.PaintEventHandler;
limited with MSSyst.Windows.Forms.PreProcessControlState;
limited with MSSyst.Windows.Forms.PreviewKeyDownEventHandler;
limited with MSSyst.Windows.Forms.QueryAccessibilityHelpEventHandler;
limited with MSSyst.Windows.Forms.QueryContinueDragEventHandler;
limited with MSSyst.Windows.Forms.RightToLeft;
limited with MSSyst.Windows.Forms.SelectionMode;
limited with MSSyst.Windows.Forms.UICuesEventHandler;
package FilesBrowser.FilesListBox is
   type Typ is new MSSyst.Windows.Forms.ListBox.Typ
         and MSSyst.ComponentModel.IComponent.Typ
         and MSSyst.IDisposable.Typ
         and MSSyst.Windows.Forms.IDropTarget.Typ
         and MSSyst.ComponentModel.ISynchronizeInvoke.Typ
         and MSSyst.Windows.Forms.IWin32Window.Typ
         and MSSyst.Windows.Forms.IBindableComponent.Typ
   with record
      null;
   end record;
   type Ref is access all Typ'Class;
   type Ref_addrof is access all Ref;
   type Ref_Arr is array(Natural range <>) of Ref;
   type Ref_Array is access all Ref_Arr;
   type Ref_Array_addrof is access all Ref_Array;
   function new_FilesListBox(
      This : Ref := null) return Ref;
   function new_FilesListBox(
      This : Ref := null;
      directoryName : access MSSyst.String.Typ'Class) return Ref;
   procedure add_FileSelected(
      This : access Typ;
      value : access FilesBrowser.FileSelectedEventHandler.Typ'Class);
   function get_Extension(
      This : access Typ) return access MSSyst.String.Typ'Class;
   function get_FileIconSize(
      This : access Typ) return FilesBrowser.IconSize.Valuetype;
   function get_ItemHeight(
      This : access Typ) return Integer;
   function get_SelectedFile(
      This : access Typ) return access MSSyst.String.Typ'Class;
   function get_SelectedFiles(
      This : access Typ) return access MSSyst.String.Ref_arr;
   function get_SelectedPath(
      This : access Typ) return access MSSyst.String.Typ'Class;
   function get_ShowBackIcon(
      This : access Typ) return Standard.Boolean;
   function get_ShowDirectories(
      This : access Typ) return Standard.Boolean;
   procedure remove_FileSelected(
      This : access Typ;
      value : access FilesBrowser.FileSelectedEventHandler.Typ'Class);
   procedure set_Extension(
      This : access Typ;
      value : access MSSyst.String.Typ'Class);
   procedure set_FileIconSize(
      This : access Typ;
      value : FilesBrowser.IconSize.Valuetype);
   procedure set_ItemHeight(
      This : access Typ;
      value : Integer);
   procedure set_SelectedPath(
      This : access Typ;
      value : access MSSyst.String.Typ'Class);
   procedure set_ShowBackIcon(
      This : access Typ;
      value : Standard.Boolean);
   procedure set_ShowDirectories(
      This : access Typ;
      value : Standard.Boolean);
private
   pragma Convention(MSIL,Typ);
   pragma MSIL_Constructor(new_FilesListBox);
   pragma Import(MSIL,add_FileSelected,"add_FileSelected");
   pragma Import(MSIL,get_Extension,"get_Extension");
   pragma Import(MSIL,get_FileIconSize,"get_FileIconSize");
   pragma Import(MSIL,get_ItemHeight,"get_ItemHeight");
   pragma Import(MSIL,get_SelectedFile,"get_SelectedFile");
   pragma Import(MSIL,get_SelectedFiles,"get_SelectedFiles");
   pragma Import(MSIL,get_SelectedPath,"get_SelectedPath");
   pragma Import(MSIL,get_ShowBackIcon,"get_ShowBackIcon");
   pragma Import(MSIL,get_ShowDirectories,"get_ShowDirectories");
   pragma Import(MSIL,remove_FileSelected,"remove_FileSelected");
   pragma Import(MSIL,set_Extension,"set_Extension");
   pragma Import(MSIL,set_FileIconSize,"set_FileIconSize");
   pragma Import(MSIL,set_ItemHeight,"set_ItemHeight");
   pragma Import(MSIL,set_SelectedPath,"set_SelectedPath");
   pragma Import(MSIL,set_ShowBackIcon,"set_ShowBackIcon");
   pragma Import(MSIL,set_ShowDirectories,"set_ShowDirectories");
end FilesBrowser.FilesListBox;
pragma Import(MSIL,FilesBrowser.FilesListBox,
   ".ver 4:0:5:2",
   "[raptor]FilesBrowser.FilesListBox");
