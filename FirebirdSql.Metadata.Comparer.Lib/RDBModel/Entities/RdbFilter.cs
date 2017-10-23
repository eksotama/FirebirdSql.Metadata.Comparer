using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FILTERS stores information about BLOB filters.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-filters.html"/>
    /// </summary>
    public class RdbFilter
    {
        /// <summary>
        /// The unique identifier of the BLOB filter
        /// </summary>
        [Key, MaxLength(31)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Documentation about the BLOB filter and the two subtypes it is used with, written by the user
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The name of the dynamic library or shared object where the code of the BLOB filter is located
        /// </summary>
        [MaxLength(255)]
        public string ModuleName { get; set; }

        /// <summary>
        /// The exported name of the BLOB filter in the filter library. Note, this is often not the same as RDB$FUNCTION_NAME, which is the identifier with which the BLOB filter is declared to the database
        /// </summary>
        [MaxLength(31)]
        public string Entrypoint { get; set; }

        /// <summary>
        /// The BLOB subtype of the data to be converted by the function
        /// </summary>
        public short InputSubType { get; set; }

        /// <summary>
        /// The BLOB subtype of the converted data
        /// </summary>
        public short OutputSubtype { get; set; }

        /// <summary>
        /// Flag indicating whether the filter is user-defined or internally defined:
        /// 0 = user-defined
        /// 1 or greater = internally defined
        /// </summary>
        public short SystemFlag { get; set; }
    }
}
