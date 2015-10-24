//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IFronteranet.Gc.Data
{
    using ITela.Gc;
    
    
    /// <summary>
    /// 
    /// </summary>
    [GcMetadata("http://docs.oasis-open.org/ubl/os-UBL-2.1/cl/gc/default/UnitOfMeasureCode-2.1.gc", IsRestriction=true)]
    [GcEnumField("code", GcEnumPart.Code, DataType="Code", Min=1, Max=20)]
    [GcEnumField("status", DataType="StringValue<StringMin1, StringMax1>", Min=1, Max=1)]
    [GcEnumField("name", GcEnumPart.Value, GcEnumPart.Comments, DataType="Description", Min=1, Max=100)]
    [GcEnumField("description", GcEnumPart.CommentsAdditional, DataType="Memo", Min=1, Max=1000)]
    [GcEnumField("levelcategory", DataType="StringValue<StringMin1, StringMax7>", Min=1, Max=7)]
    [GcEnumField("symbol", DataType="StringValue<StringMin1, StringMax20>", Min=1, Max=20)]
    [GcEnumField("conversionfactor", DataType="StringValue<StringMin1, StringMax40>", Min=1, Max=40)]
    public enum UnitOfVolume
    {
        
        /// <summary>
        /// gallon (US)
        /// </summary>
        [GcCodeValue("GLL", "gallon (US)")]
        Gallon,
    }
}