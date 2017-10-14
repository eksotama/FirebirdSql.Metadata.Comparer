using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class FieldTests : RdbEntityTestBase<RdbField>
    {
        public FieldTests(ConfigurationFixture fixture) : base(fixture)
        {
        }

        [Theory]
        [InlineData(0, RdbFieldBlobSubtype.UNTYPED)]
        [InlineData(1, RdbFieldBlobSubtype.TEXT)]
        [InlineData(2, RdbFieldBlobSubtype.BLR)]
        [InlineData(3, RdbFieldBlobSubtype.ACCESS_CONTROL_LIST)]
        [InlineData(4, RdbFieldBlobSubtype.RESERVED)]
        [InlineData(5, RdbFieldBlobSubtype.ENCODED_TABLE_METADATA_DESCRIPTION)]
        [InlineData(6, RdbFieldBlobSubtype.CROSS_DATABASE_TRANSACTION_DETAILS)]
        public void BlobSubtypeTest(short subtype, RdbFieldBlobSubtype expected)
        {
            var testEntity = new RdbField
            {
                FieldType = RdbFieldType.BLOB,
                FieldSubType = subtype
            };

            Assert.Equal(expected, testEntity.FieldSubTypeNamed);
        }

        [Theory]
        [InlineData(0, RdbFieldCharSubtype.UNTYPED)]
        [InlineData(1, RdbFieldCharSubtype.BINARY)]
        public void CharSubtypeTest(short subtype, RdbFieldCharSubtype expected)
        {
            var testEntity = new RdbField
            {
                FieldType = RdbFieldType.CHAR,
                FieldSubType = subtype
            };

            Assert.Equal(expected, testEntity.FieldSubTypeNamed);
        }

        [Theory]
        [InlineData(null, RdbFieldIntegerSubtype.SELF)]
        [InlineData((short)0, RdbFieldIntegerSubtype.SELF)]
        [InlineData((short)1, RdbFieldIntegerSubtype.NUMERIC)]
        [InlineData((short)2, RdbFieldIntegerSubtype.DECIMAL)]
        public void IntSubtypeTest(short? subtype, RdbFieldIntegerSubtype expected)
        {
            var testEntity = new RdbField
            {
                FieldType = RdbFieldType.INTEGER,
                FieldSubType = subtype
            };

            Assert.Equal(expected, testEntity.FieldSubTypeNamed);
        }
    }
}
