using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$TRANSACTIONS stores the states of distributed transactions and other transactions that were prepared for two-phase commit with an explicit prepare message
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-transacs.html"/>
    /// </summary>
    public class RdbTransaction
    {
        /// <summary>
        /// The unique identifier of the transaction being tracked
        /// </summary>
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// Transaction state:
        /// 0 - in limbo
        /// 1 - committed
        /// 2 - rolled back
        /// </summary>
        public short TransactionState { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Describes the prepared transaction and could be a custom message supplied to <code>isc_prepare_transaction2</code>, 
        /// even if it is not a distributed transaction. It may be used when a lost connection cannot be restored
        /// </summary>
        public string TransactionDescription { get; set; }
    }
}
