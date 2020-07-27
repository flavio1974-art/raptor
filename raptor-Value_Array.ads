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
limited with numbers.value;
package raptor.Value_Array is
   type Typ is new MSSyst.Object.Typ   with record
      null;
   end record;
   type Ref is access all Typ'Class;
   type Ref_addrof is access all Ref;
   type Ref_Arr is array(Natural range <>) of Ref;
   type Ref_Array is access all Ref_Arr;
   type Ref_Array_addrof is access all Ref_Array;
   function new_Value_Array(
      This : Ref := null) return Ref;
   function get_Doublea(
      This : access Typ) return MSIL_Types.Float64_Array;
   function get_Int32a(
      This : access Typ) return MSIL_Types.Int32_Array;
   function Get_Length(
      This : access Typ) return Integer;
   function get_Singlea(
      This : access Typ) return MSIL_Types.Float32_Array;
   function Get_Value(
      This : access Typ;
      value_index : access numbers.value.Typ'Class) return access numbers.value.Typ'Class;
   procedure set_Doublea(
      This : access Typ;
      values : MSIL_Types.Float64_Arr);
   procedure set_Int32a(
      This : access Typ;
      values : MSIL_Types.Int32_Arr);
   procedure set_Singlea(
      This : access Typ;
      values : MSIL_Types.Float32_Arr);
   procedure Set_Value(
      This : access Typ;
      value_index : access numbers.value.Typ'Class;
      v : access numbers.value.Typ'Class);
private
   pragma Convention(MSIL,Typ);
   pragma MSIL_Constructor(new_Value_Array);
   pragma Import(MSIL,get_Doublea,"get_Doublea");
   pragma Import(MSIL,get_Int32a,"get_Int32a");
   pragma Import(MSIL,Get_Length,"Get_Length");
   pragma Import(MSIL,get_Singlea,"get_Singlea");
   pragma Import(MSIL,Get_Value,"Get_Value");
   pragma Import(MSIL,set_Doublea,"set_Doublea");
   pragma Import(MSIL,set_Int32a,"set_Int32a");
   pragma Import(MSIL,set_Singlea,"set_Singlea");
   pragma Import(MSIL,Set_Value,"Set_Value");
end raptor.Value_Array;
pragma Import(MSIL,raptor.Value_Array,
   ".ver 4:0:5:2",
   "[raptor]raptor.Value_Array");
