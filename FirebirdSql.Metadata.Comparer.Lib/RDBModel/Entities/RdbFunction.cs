using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FUNCTIONS stores the information needed by the engine about external functions (user-defined functions, UDFs).
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-functions.html"/>
    /// </summary>
    /// <remarks>
    /// In future major releases (Firebird 3.0 +) RDB$FUNCTIONS will also store the information about stored functions: user-defined functions written in PSQL.
    /// </remarks>
    public class RdbFunction
    {
        /// <summary>
        /// The unique (declared) name of the external function
        /// </summary>
        [Key, MaxLength(31)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        public short? FunctionType { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        [MaxLength(31)]
        public string QueryName { get; set; }

        /// <summary>
        /// Any text with comments related to the external function
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The name of the dynamic library or shared object where the code of the external function is located
        /// </summary>
        [MaxLength(255)]
        public string ModuleName { get; set; }

        /// <summary>
        /// The exported name of the external function in the function library. Note, this is often not the same as RDB$FUNCTION_NAME, which is the identifier with which the external function is declared to the database
        /// </summary>
        public string Entrypoint { get; set; }

        /// <summary>
        /// The position number of the returned argument in the list of parameters corresponding to input arguments
        /// </summary>
        public short ReturnArgument { get; set; }

        /// <summary>
        /// Flag indicating whether the filter is user-defined or internally defined:
        ///  0 = user-defined
        ///  1 = internally defined
        /// </summary>
        public short SystemFlag { get; set; }
    }
}
