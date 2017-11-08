using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$TRIGGERS stores the trigger definitions for all tables and views.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-triggers.html"/>
    /// </summary>
    public class RdbTrigger
    {
        /// <summary>
        /// Trigger name
        /// </summary>
        [Key, MaxLength(31)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The name of the table or view the trigger applies to. NULL if the trigger is applicable to a database event (“database trigger”)
        /// </summary>
        [MaxLength(31)]
        public string RelationName { get; set; }

        /// <summary>
        /// Position of this trigger in the sequence. Zero usually means that no sequence position is specified
        /// </summary>
        public short TriggerSequence { get; set; }

        /// <summary>
        /// The event the trigger fires on:
        /// 1 - before insert
        /// 2 - after insert
        /// 3 - before update
        /// 4 - after update
        /// 5 - before delete
        /// 6 - after delete
        /// 17 - before insert or update
        /// 18 - after insert or update
        /// 25 - before insert or delete
        /// 26 - after insert or delete
        /// 27 - before update or delete
        /// 28 - after update or delete
        /// 113 - before insert or update or delete
        /// 114 - after insert or update or delete
        /// 8192 - on connect
        /// 8193 - on disconnect
        /// 8194 - on transaction start
        /// 8195 - on transaction commit
        /// 8196 - on transaction rollback
        /// </summary>
        /// <remarks>
        /// Identification of the exact RDB$TRIGGER_TYPE code is a little more complicated, 
        /// since it is a bitmap, calculated according to which phase and events are covered 
        /// and the order in which they are defined. For the curious, 
        /// the calculation is explained in this blog by Mark Rotteveel.
        /// <see href="http://tinyurl.com/fb-triggertype"/>
        /// </remarks>
        public short TriggerType { get; set; }

        /// <summary>
        /// Stores the source code of the trigger in PSQL
        /// </summary>
        public string TriggerSource { get; set; }

        /// <summary>
        /// Stores the trigger in the binary language representation (BLR)
        /// </summary>
        public byte[] TriggerBlr { get; set; }

        /// <summary>
        /// Trigger comment text
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the trigger is currently inactive (1) or active (0)
        /// </summary>
        public short? TriggerInactive { get; set; }

        /// <summary>
        /// Flag: indicates whether the trigger is user-defined (value 0) or system-defined (value 1 or greater)
        /// </summary>
        public short SystemFlag { get; set; }

        /// <summary>
        /// Internal use
        /// </summary>
        public short Flags { get; set; }

        /// <summary>
        /// Indicates whether the text of the trigger remains valid after the latest modification by the the ALTER TRIGGER statement
        /// </summary>
        public short? ValidBlr { get; set; }

        /// <summary>
        /// Contains debugging information about variables used in the trigger
        /// </summary>
        public string DebugInfo { get; set; }
    }
}
