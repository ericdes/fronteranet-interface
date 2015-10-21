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

namespace IFronteranet.Gc
{
    using ITela.Gc;
    
    
    /// <summary>
    /// 
    /// </summary>
    [GcMetadata("http://docs.oasis-open.org/ubl/os-UBL-2.1/cl/gc/default/PackagingTypeCode-2.1.gc", IsRestriction=true)]
    [GcEnumField("code", GcEnumPart.Code, DataType="PackagingTypeCode", Min=2, Max=2)]
    [GcEnumField("status", DataType="StringValue<StringMin1, StringMax1>", Min=1, Max=1)]
    [GcEnumField("name", GcEnumPart.Value, GcEnumPart.Comments, DataType="Description", Min=1, Max=100)]
    [GcEnumField("description", DataType="Memo", Min=1, Max=1000)]
    [GcEnumField("numeric", DataType="StringValue<StringMin1, StringMax47>", Min=1, Max=47)]
    public enum PackagingType
    {
        
        /// <summary>
        /// Pallet
        /// </summary>
        [GcCodeValue("PX", "Pallet")]
        Pallet,
        
        /// <summary>
        /// Bag
        /// </summary>
        [GcCodeValue("BG", "Bag")]
        Bag,
        
        /// <summary>
        /// Basket
        /// </summary>
        [GcCodeValue("BK", "Basket")]
        Basket,
        
        /// <summary>
        /// Box
        /// </summary>
        [GcCodeValue("BX", "Box")]
        Box,
        
        /// <summary>
        /// Barrel
        /// </summary>
        [GcCodeValue("BA", "Barrel")]
        Barrel,
        
        /// <summary>
        /// Container, not otherwise specified as transport equipment
        /// </summary>
        [GcCodeValue("CN", "Container, not otherwise specified as transport equipment")]
        Container,
        
        /// <summary>
        /// Coil
        /// </summary>
        [GcCodeValue("CL", "Coil")]
        Coil,
        
        /// <summary>
        /// Bunch
        /// </summary>
        [GcCodeValue("BH", "Bunch")]
        Bunch,
        
        /// <summary>
        /// Crate
        /// </summary>
        [GcCodeValue("CR", "Crate")]
        Crate,
        
        /// <summary>
        /// Drum
        /// </summary>
        [GcCodeValue("DR", "Drum")]
        Drum,
        
        /// <summary>
        /// Envelope
        /// </summary>
        [GcCodeValue("EN", "Envelope")]
        Envelop,
        
        /// <summary>
        /// Pail
        /// </summary>
        [GcCodeValue("PL", "Pail")]
        Pail,
        
        /// <summary>
        /// Reel
        /// </summary>
        [GcCodeValue("RL", "Reel")]
        Reel,
        
        /// <summary>
        /// Roll
        /// </summary>
        [GcCodeValue("RO", "Roll")]
        Roll,
        
        /// <summary>
        /// Tube
        /// </summary>
        [GcCodeValue("TU", "Tube")]
        Tube,
        
        /// <summary>
        /// Bundle
        /// </summary>
        [GcCodeValue("BE", "Bundle")]
        Bundle,
        
        /// <summary>
        /// Bin
        /// </summary>
        [GcCodeValue("BI", "Bin")]
        Bin,
        
        /// <summary>
        /// Case
        /// </summary>
        [GcCodeValue("CS", "Case")]
        Case,
        
        /// <summary>
        /// Sack
        /// </summary>
        [GcCodeValue("SA", "Sack")]
        Sack,
        
        /// <summary>
        /// Skid
        /// </summary>
        [GcCodeValue("SI", "Skid")]
        Skid,
        
        /// <summary>
        /// Bag, tote
        /// </summary>
        [GcCodeValue("TT", "Bag, tote")]
        Tote,
        
        /// <summary>
        /// Tray
        /// </summary>
        [GcCodeValue("PU", "Tray")]
        Tray,
        
        /// <summary>
        /// Container, gallon
        /// </summary>
        [GcCodeValue("GL", "Container, gallon")]
        Gallon,
        
        /// <summary>
        /// Bucket
        /// </summary>
        [GcCodeValue("BJ", "Bucket")]
        Bucket,
        
        /// <summary>
        /// Piece
        /// </summary>
        [GcCodeValue("PP", "Piece")]
        Piece,
    }
}
