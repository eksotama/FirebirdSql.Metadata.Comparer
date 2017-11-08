using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$TRIGGER_MESSAGES stores the trigger messages.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-trigmsgs.html"/>
    /// </summary>
    public class RdbTriggerMessage
    {
        /// <summary>
        /// The name of the trigger the message is associated with
        /// </summary>
        [Key, MaxLength(31)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The number of the message within this trigger (from 1 to 32,767)
        /// </summary>
        public short MessageNumber { get; set; }

        /// <summary>
        /// Text of the trigger message
        /// </summary>
        [MaxLength(1023)]
        public string Message { get; set; }
    }
}
