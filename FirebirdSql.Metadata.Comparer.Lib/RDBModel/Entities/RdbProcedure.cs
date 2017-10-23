using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$PROCEDURES stores the definitions of stored procedures, 
    /// including their PSQL source code and the binary language representation (BLR) of it. 
    /// The next table, RDB$PROCEDURE_PARAMETERS, stores the definitions of input and output parameters.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-procedures.html"/>
    /// </summary>
    public class RdbProcedure
    {
        /// <summary>
        /// Stored procedure name (identifier)
        /// </summary>
        [Key, MaxLength(31)]
        public string ProcedureName { get; set; }

        /// <summary>
        /// The procedure's unique, system-generated identifier
        /// </summary>
        public short ProcedureId { get; set; }

        /// <summary>
        /// Indicates the number of input parameters. NULL if there are none
        /// </summary>
        public short? ProcedureInputs { get; set; }

        /// <summary>
        /// Indicates the number of output parameters. NULL if there are none
        /// </summary>
        public short? ProcedureOutputs { get; set; }

        /// <summary>
        /// 	Any text comments related to the procedure
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The PSQL source code of the procedure
        /// </summary>
        public string ProcedureSource { get; set; }

        /// <summary>
        /// The binary language representation (BLR) of the procedure code
        /// </summary>
        public byte[] ProcedureBlr { get; set; }

        /// <summary>
        /// May point to the security class defined in the system table RDB$SECURITY_CLASSES 
        /// in order to apply access control limits
        /// </summary>
        [MaxLength(31)]
        public string SecurityClass { get; set; }

        /// <summary>
        /// The user name of the procedure's Owner—the user who was CURRENT_USER 
        /// when the procedure was first created. It may or may not be the user name of the author
        /// </summary>
        [MaxLength(31)]
        public string OwnerName { get; set; }

        /// <summary>
        /// A metadata description of the procedure, used internally for optimization
        /// </summary>
        public string Runtime { get; set; }

        /// <summary>
        /// Indicates whether the procedure is defined by a user (value 0) or by the system (a value of 1 or greater)
        /// </summary>
        public short SystemFlag { get; set; }

        /// <summary>
        /// Procedure type:
        /// 1 - selectable stored procedure(contains a SUSPEND statement)
        /// 2 - executable stored procedure
        /// NULL - not known *
        /// * for procedures created before Firebird 1.5
        /// </summary>
        public short ProcedureType { get; set; }

        /// <summary>
        /// Indicates whether the source PSQL of the stored procedure remains valid after the latest ALTER PROCEDURE modification
        /// </summary>
        public short ValidBlr { get; set; }

        /// <summary>
        /// Contains debugging information about variables used in the stored procedure
        /// </summary>
        public string DebugInfo { get; set; }
    }
}
