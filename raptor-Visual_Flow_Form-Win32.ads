-- Autogenerated by MSIL2Ada v. 2
-- By: Martin C. Carlisle
--     Department of Computer Science
--     US Air Force Academy
--     carlislem@acm.org
with MSSyst.Object;
with MSIL_Types;
use MSIL_Types;
limited with MSSyst.String;
limited with MSSyst.Type_k;
with raptor.Visual_Flow_Form;
package raptor.Visual_Flow_Form.Win32 is
   type Typ is new MSSyst.Object.Typ   with record
      null;
   end record;
   type Ref is access all Typ'Class;
   type Ref_addrof is access all Ref;
   type Ref_Arr is array(Natural range <>) of Ref;
   type Ref_Array is access all Ref_Arr;
   type Ref_Array_addrof is access all Ref_Array;
   function new_Win32(
      This : Ref := null) return Ref;
   function CloseClipboard return Standard.Boolean;
   function CopyEnhMetaFile(
      hemfSrc : MSIL_Types.native_int;
      hNULL : MSIL_Types.native_int) return MSIL_Types.native_int;
   function DeleteEnhMetaFile(
      hemf : MSIL_Types.native_int) return Standard.Boolean;
   function EmptyClipboard return Standard.Boolean;
   function OpenClipboard(
      hWndNewOwner : MSIL_Types.native_int) return Standard.Boolean;
   function SetClipboardData(
      uFormat : MSIL_Types.Unsigned_Integer;
      hMem : MSIL_Types.native_int) return MSIL_Types.native_int;
private
   pragma Convention(MSIL,Typ);
   pragma MSIL_Constructor(new_Win32);
   pragma Import(MSIL,CloseClipboard,"CloseClipboard");
   pragma Import(MSIL,CopyEnhMetaFile,"CopyEnhMetaFile");
   pragma Import(MSIL,DeleteEnhMetaFile,"DeleteEnhMetaFile");
   pragma Import(MSIL,EmptyClipboard,"EmptyClipboard");
   pragma Import(MSIL,OpenClipboard,"OpenClipboard");
   pragma Import(MSIL,SetClipboardData,"SetClipboardData");
end raptor.Visual_Flow_Form.Win32;
pragma Import(MSIL,raptor.Visual_Flow_Form.Win32,
   ".ver 4:0:5:2",
   "[raptor]raptor.Visual_Flow_Form/Win32");
