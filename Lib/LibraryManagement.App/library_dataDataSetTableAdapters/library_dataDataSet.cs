using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace LibraryManagement.App
{


    [Serializable, ToolboxItem(true), XmlRoot("library_dataDataSet"), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code")]
    public class library_dataDataSet : DataSet
    {
        private BooksDataTable booksDataTable_0;
        private merclocDataTable merclocDataTable_0;
        private System.Data.SchemaSerializationMode schemaSerializationMode_0;
        private tblBookAttrDataTable tblBookAttrDataTable_0;
        private tblCustomerDataTable tblCustomerDataTable_0;
        private tblGoodsDataTable tblGoodsDataTable_0;

        static library_dataDataSet()
        {
            Class15.smethod_5();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public library_dataDataSet()
        {
            Class17.smethod_0();
            this.schemaSerializationMode_0 = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.pfeZyQnoF);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected library_dataDataSet(SerializationInfo info, StreamingContext context)
            : base(info, context, false)
        {
            Class17.smethod_0();
            this.schemaSerializationMode_0 = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(info, context))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.pfeZyQnoF);
                this.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
            }
            else
            {
                string s = (string)info.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["tblBookAttr"] != null)
                    {
                        base.Tables.Add(new tblBookAttrDataTable(dataSet.Tables["tblBookAttr"]));
                    }
                    if (dataSet.Tables["tblCustomer"] != null)
                    {
                        base.Tables.Add(new tblCustomerDataTable(dataSet.Tables["tblCustomer"]));
                    }
                    if (dataSet.Tables["tblGoods"] != null)
                    {
                        base.Tables.Add(new tblGoodsDataTable(dataSet.Tables["tblGoods"]));
                    }
                    if (dataSet.Tables["Books"] != null)
                    {
                        base.Tables.Add(new BooksDataTable(dataSet.Tables["Books"]));
                    }
                    if (dataSet.Tables["mercloc"] != null)
                    {
                        base.Tables.Add(new merclocDataTable(dataSet.Tables["mercloc"]));
                    }
                    base.DataSetName = dataSet.DataSetName;
                    base.Prefix = dataSet.Prefix;
                    base.Namespace = dataSet.Namespace;
                    base.Locale = dataSet.Locale;
                    base.CaseSensitive = dataSet.CaseSensitive;
                    base.EnforceConstraints = dataSet.EnforceConstraints;
                    base.Merge(dataSet, false, MissingSchemaAction.Add);
                    this.method_0();
                }
                else
                {
                    base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                }
                base.GetSerializationData(info, context);
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.pfeZyQnoF);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            library_dataDataSet set = (library_dataDataSet)base.Clone();
            set.method_0();
            set.SchemaSerializationMode = this.SchemaSerializationMode;
            return set;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override XmlSchema GetSchemaSerializable()
        {
            MemoryStream w = new MemoryStream();
            base.WriteXmlSchema(new XmlTextWriter(w, null));
            w.Position = 0L;
            return XmlSchema.Read(new XmlTextReader(w), null);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
        {
            // This item is obfuscated and can not be translated.
            library_dataDataSet set = new library_dataDataSet();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny();
            item.Namespace = set.Namespace;
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = set.GetSchemaSerializable();
            if (xs.Contains(schemaSerializable.TargetNamespace))
            {
                MemoryStream stream = new MemoryStream();
                MemoryStream stream2 = new MemoryStream();
                try
                {
                    XmlSchema current = null;
                    schemaSerializable.Write(stream);
                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        current = (XmlSchema)enumerator.Current;
                        stream2.SetLength(0L);
                        current.Write(stream2);
                        if (stream.Length != stream2.Length)
                        {
                            continue;
                        }
                        stream.Position = 0L;
                        stream2.Position = 0L;
                        while (stream.Position == stream.Length)
                        {
                            if (0 == 0)
                            {
                                goto Label_010F;
                            }
                        }
                    Label_010F:
                        if (stream.Position == stream.Length)
                        {
                            return type;
                        }
                    }
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
            }
            xs.Add(schemaSerializable);
            return type;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            base.BeginInit();
            this.method_2();
            base.EndInit();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_0()
        {
            this.method_1(true);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_1(bool bool_0)
        {
            this.tblBookAttrDataTable_0 = (tblBookAttrDataTable)base.Tables["tblBookAttr"];
            if (bool_0 && (this.tblBookAttrDataTable_0 != null))
            {
                this.tblBookAttrDataTable_0.method_0();
            }
            this.tblCustomerDataTable_0 = (tblCustomerDataTable)base.Tables["tblCustomer"];
            if (bool_0 && (this.tblCustomerDataTable_0 != null))
            {
                this.tblCustomerDataTable_0.method_0();
            }
            this.tblGoodsDataTable_0 = (tblGoodsDataTable)base.Tables["tblGoods"];
            if (bool_0 && (this.tblGoodsDataTable_0 != null))
            {
                this.tblGoodsDataTable_0.method_0();
            }
            this.booksDataTable_0 = (BooksDataTable)base.Tables["Books"];
            if (bool_0 && (this.booksDataTable_0 != null))
            {
                this.booksDataTable_0.method_0();
            }
            this.merclocDataTable_0 = (merclocDataTable)base.Tables["mercloc"];
            if (bool_0 && (this.merclocDataTable_0 != null))
            {
                this.merclocDataTable_0.method_0();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_2()
        {
            base.DataSetName = "library_dataDataSet";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/library_dataDataSet.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tblBookAttrDataTable_0 = new tblBookAttrDataTable();
            base.Tables.Add(this.tblBookAttrDataTable_0);
            this.tblCustomerDataTable_0 = new tblCustomerDataTable();
            base.Tables.Add(this.tblCustomerDataTable_0);
            this.tblGoodsDataTable_0 = new tblGoodsDataTable();
            base.Tables.Add(this.tblGoodsDataTable_0);
            this.booksDataTable_0 = new BooksDataTable();
            base.Tables.Add(this.booksDataTable_0);
            this.merclocDataTable_0 = new merclocDataTable();
            base.Tables.Add(this.merclocDataTable_0);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_3()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_4()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_5()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_6()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_7()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void pfeZyQnoF(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["tblBookAttr"] != null)
                {
                    base.Tables.Add(new tblBookAttrDataTable(dataSet.Tables["tblBookAttr"]));
                }
                if (dataSet.Tables["tblCustomer"] != null)
                {
                    base.Tables.Add(new tblCustomerDataTable(dataSet.Tables["tblCustomer"]));
                }
                if (dataSet.Tables["tblGoods"] != null)
                {
                    base.Tables.Add(new tblGoodsDataTable(dataSet.Tables["tblGoods"]));
                }
                if (dataSet.Tables["Books"] != null)
                {
                    base.Tables.Add(new BooksDataTable(dataSet.Tables["Books"]));
                }
                if (dataSet.Tables["mercloc"] != null)
                {
                    base.Tables.Add(new merclocDataTable(dataSet.Tables["mercloc"]));
                }
                base.DataSetName = dataSet.DataSetName;
                base.Prefix = dataSet.Prefix;
                base.Namespace = dataSet.Namespace;
                base.Locale = dataSet.Locale;
                base.CaseSensitive = dataSet.CaseSensitive;
                base.EnforceConstraints = dataSet.EnforceConstraints;
                base.Merge(dataSet, false, MissingSchemaAction.Add);
                this.method_0();
            }
            else
            {
                base.ReadXml(reader);
                this.method_0();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public BooksDataTable Books
        {
            get
            {
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public merclocDataTable mercloc
        {
            get
            {
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public override System.Data.SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this.schemaSerializationMode_0;
            }
            set
            {
                this.schemaSerializationMode_0 = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tblBookAttrDataTable tblBookAttr
        {
            get
            {
            }
        }

        [Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblCustomerDataTable tblCustomer
        {
            get
            {
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
        public tblGoodsDataTable tblGoods
        {
            get
            {
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class BooksDataTable : DataTable, IEnumerable
        {
            private library_dataDataSet.BooksRowChangeEventHandler booksRowChangeEventHandler_0;
            private library_dataDataSet.BooksRowChangeEventHandler booksRowChangeEventHandler_1;
            private library_dataDataSet.BooksRowChangeEventHandler booksRowChangeEventHandler_2;
            private library_dataDataSet.BooksRowChangeEventHandler booksRowChangeEventHandler_3;
            private DataColumn dataColumn_0;
            private DataColumn dataColumn_1;
            private DataColumn dataColumn_10;
            private DataColumn dataColumn_11;
            private DataColumn dataColumn_12;
            private DataColumn dataColumn_13;
            private DataColumn dataColumn_14;
            private DataColumn dataColumn_15;
            private DataColumn dataColumn_2;
            private DataColumn dataColumn_3;
            private DataColumn dataColumn_4;
            private DataColumn dataColumn_5;
            private DataColumn dataColumn_6;
            private DataColumn dataColumn_7;
            private DataColumn dataColumn_8;
            private DataColumn dataColumn_9;
            private DataColumn wrrOadbVv;
            private DataColumn wZaclpluc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.BooksRowChangeEventHandler BooksRowChanged
            {
                add
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.BooksRowChangeEventHandler BooksRowChanging
            {
                add
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.BooksRowChangeEventHandler BooksRowDeleted
            {
                add
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.BooksRowChangeEventHandler BooksRowDeleting
            {
                add
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.BooksRowChangeEventHandler handler2;
                    library_dataDataSet.BooksRowChangeEventHandler handler = this.booksRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.BooksRowChangeEventHandler handler3 = (library_dataDataSet.BooksRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.BooksRowChangeEventHandler>(ref this.booksRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            static BooksDataTable()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BooksDataTable()
            {
                Class17.smethod_0();
                base.TableName = "Books";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal BooksDataTable(DataTable table)
            {
                Class17.smethod_0();
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected BooksDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                Class17.smethod_0();
                this.method_0();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddBooksRow(library_dataDataSet.BooksRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.BooksRow AddBooksRow(string goods_id, string barcode, string grp_id, decimal id, string full_name, byte[] image, string author, string publish, string translator, int pl_month, int pl_year, string dimension, int weight, int pages, string introinfo, string grpname, string langguge, string frmtype)
            {
                library_dataDataSet.BooksRow row = (library_dataDataSet.BooksRow)base.NewRow();
                row.ItemArray = new object[] { 
                    goods_id, barcode, grp_id, id, full_name, image, author, publish, translator, pl_month, pl_year, dimension, weight, pages, introinfo, grpname, 
                    langguge, frmtype
                 };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                library_dataDataSet.BooksDataTable table = (library_dataDataSet.BooksDataTable)base.Clone();
                table.method_0();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new library_dataDataSet.BooksDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(library_dataDataSet.BooksRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                // This item is obfuscated and can not be translated.
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                library_dataDataSet set = new library_dataDataSet();
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);

                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "BooksDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema)enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length != stream2.Length)
                            {
                                continue;
                            }
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while (stream.Position == stream.Length)
                            {
                                if (0 == 0)
                                {
                                    goto Label_01C2;
                                }
                            }
                            goto Label_019A;
                        Label_01C2:
                            if (stream.Position == stream.Length)
                            {
                                return type;
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_0()
            {
                this.dataColumn_0 = base.Columns["goods_id"];
                this.dataColumn_1 = base.Columns["barcode"];
                this.wZaclpluc = base.Columns["grp_id"];
                this.dataColumn_2 = base.Columns["id"];
                this.wrrOadbVv = base.Columns["full_name"];
                this.dataColumn_3 = base.Columns["image"];
                this.dataColumn_4 = base.Columns["author"];
                this.dataColumn_5 = base.Columns["publish"];
                this.dataColumn_6 = base.Columns["translator"];
                this.dataColumn_7 = base.Columns["pl_month"];
                this.dataColumn_8 = base.Columns["pl_year"];
                this.dataColumn_9 = base.Columns["dimension"];
                this.dataColumn_10 = base.Columns["weight"];
                this.dataColumn_11 = base.Columns["pages"];
                this.dataColumn_12 = base.Columns["introinfo"];
                this.dataColumn_13 = base.Columns["grpname"];
                this.dataColumn_14 = base.Columns["langguge"];
                this.dataColumn_15 = base.Columns["frmtype"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_1()
            {
                this.dataColumn_0 = new DataColumn("goods_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_0);
                this.dataColumn_1 = new DataColumn("barcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_1);
                this.wZaclpluc = new DataColumn("grp_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.wZaclpluc);
                this.dataColumn_2 = new DataColumn("id", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_2);
                this.wrrOadbVv = new DataColumn("full_name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.wrrOadbVv);
                this.dataColumn_3 = new DataColumn("image", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_3);
                this.dataColumn_4 = new DataColumn("author", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_4);
                this.dataColumn_5 = new DataColumn("publish", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_5);
                this.dataColumn_6 = new DataColumn("translator", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_6);
                this.dataColumn_7 = new DataColumn("pl_month", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_7);
                this.dataColumn_8 = new DataColumn("pl_year", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_8);
                this.dataColumn_9 = new DataColumn("dimension", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_9);
                this.dataColumn_10 = new DataColumn("weight", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_10);
                this.dataColumn_11 = new DataColumn("pages", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_11);
                this.dataColumn_12 = new DataColumn("introinfo", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_12);
                this.dataColumn_13 = new DataColumn("grpname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_13);
                this.dataColumn_14 = new DataColumn("langguge", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_14);
                this.dataColumn_15 = new DataColumn("frmtype", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_15);
                this.dataColumn_0.AllowDBNull = false;
                this.dataColumn_0.MaxLength = 6;
                this.dataColumn_1.AllowDBNull = false;
                this.dataColumn_1.MaxLength = 20;
                this.wZaclpluc.MaxLength = 50;
                this.wrrOadbVv.AllowDBNull = false;
                this.wrrOadbVv.MaxLength = 200;
                this.dataColumn_4.AllowDBNull = false;
                this.dataColumn_4.MaxLength = 200;
                this.dataColumn_5.AllowDBNull = false;
                this.dataColumn_5.MaxLength = 200;
                this.dataColumn_6.AllowDBNull = false;
                this.dataColumn_6.MaxLength = 200;
                this.dataColumn_7.AllowDBNull = false;
                this.dataColumn_8.AllowDBNull = false;
                this.dataColumn_9.AllowDBNull = false;
                this.dataColumn_9.MaxLength = 100;
                this.dataColumn_10.AllowDBNull = false;
                this.dataColumn_11.AllowDBNull = false;
                this.dataColumn_12.AllowDBNull = false;
                this.dataColumn_12.MaxLength = 0x5dc;
                this.dataColumn_13.AllowDBNull = false;
                this.dataColumn_13.MaxLength = 100;
                this.dataColumn_14.MaxLength = 100;
                this.dataColumn_15.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.BooksRow NewBooksRow()
            {
                return (library_dataDataSet.BooksRow)base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new library_dataDataSet.BooksRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.booksRowChangeEventHandler_1 != null)
                {
                    this.booksRowChangeEventHandler_1(this, new library_dataDataSet.BooksRowChangeEvent((library_dataDataSet.BooksRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.booksRowChangeEventHandler_0 != null)
                {
                    this.booksRowChangeEventHandler_0(this, new library_dataDataSet.BooksRowChangeEvent((library_dataDataSet.BooksRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.booksRowChangeEventHandler_3 != null)
                {
                    this.booksRowChangeEventHandler_3(this, new library_dataDataSet.BooksRowChangeEvent((library_dataDataSet.BooksRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.booksRowChangeEventHandler_2 != null)
                {
                    this.booksRowChangeEventHandler_2(this, new library_dataDataSet.BooksRowChangeEvent((library_dataDataSet.BooksRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void RemoveBooksRow(library_dataDataSet.BooksRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn authorColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn barcodeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dimensionColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn frmtypeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn full_nameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn goods_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn grp_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn grpnameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn imageColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn introinfoColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.BooksRow this[int index]
            {
                get
                {
                    return (library_dataDataSet.BooksRow)base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn langgugeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn pagesColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn pl_monthColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn pl_yearColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn publishColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn translatorColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn weightColumn
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        public class BooksRow : DataRow
        {
            private library_dataDataSet.BooksDataTable booksDataTable_0;

            static BooksRow()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal BooksRow(DataRowBuilder rb)
                : base(rb)
            {
                Class17.smethod_0();
                this.booksDataTable_0 = (library_dataDataSet.BooksDataTable)base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsfrmtypeNull()
            {
                return base.IsNull(this.booksDataTable_0.frmtypeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isgrp_idNull()
            {
                return base.IsNull(this.booksDataTable_0.grp_idColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsidNull()
            {
                return base.IsNull(this.booksDataTable_0.idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsimageNull()
            {
                return base.IsNull(this.booksDataTable_0.imageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IslanggugeNull()
            {
                return base.IsNull(this.booksDataTable_0.langgugeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetfrmtypeNull()
            {
                base[this.booksDataTable_0.frmtypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setgrp_idNull()
            {
                base[this.booksDataTable_0.grp_idColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetidNull()
            {
                base[this.booksDataTable_0.idColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetimageNull()
            {
                base[this.booksDataTable_0.imageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetlanggugeNull()
            {
                base[this.booksDataTable_0.langgugeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string author
            {
                get
                {
                    return (string)base[this.booksDataTable_0.authorColumn];
                }
                set
                {
                    base[this.booksDataTable_0.authorColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string barcode
            {
                get
                {
                    return (string)base[this.booksDataTable_0.barcodeColumn];
                }
                set
                {
                    base[this.booksDataTable_0.barcodeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string dimension
            {
                get
                {
                    return (string)base[this.booksDataTable_0.dimensionColumn];
                }
                set
                {
                    base[this.booksDataTable_0.dimensionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string frmtype
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.booksDataTable_0.frmtypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'frmtype' in table 'Books' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.booksDataTable_0.frmtypeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string full_name
            {
                get
                {
                    return (string)base[this.booksDataTable_0.full_nameColumn];
                }
                set
                {
                    base[this.booksDataTable_0.full_nameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string goods_id
            {
                get
                {
                    return (string)base[this.booksDataTable_0.goods_idColumn];
                }
                set
                {
                    base[this.booksDataTable_0.goods_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string grp_id
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.booksDataTable_0.grp_idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'grp_id' in table 'Books' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.booksDataTable_0.grp_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string grpname
            {
                get
                {
                    return (string)base[this.booksDataTable_0.grpnameColumn];
                }
                set
                {
                    base[this.booksDataTable_0.grpnameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal id
            {
                get
                {
                    decimal num;
                    try
                    {
                        num = (decimal)base[this.booksDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'Books' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.booksDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte[] image
            {
                get
                {
                    byte[] buffer;
                    try
                    {
                        buffer = (byte[])base[this.booksDataTable_0.imageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'image' in table 'Books' is DBNull.", exception);
                    }
                    return buffer;
                }
                set
                {
                    base[this.booksDataTable_0.imageColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string introinfo
            {
                get
                {
                    return (string)base[this.booksDataTable_0.introinfoColumn];
                }
                set
                {
                    base[this.booksDataTable_0.introinfoColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string langguge
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.booksDataTable_0.langgugeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'langguge' in table 'Books' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.booksDataTable_0.langgugeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int pages
            {
                get
                {
                    return (int)base[this.booksDataTable_0.pagesColumn];
                }
                set
                {
                    base[this.booksDataTable_0.pagesColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int pl_month
            {
                get
                {
                    return (int)base[this.booksDataTable_0.pl_monthColumn];
                }
                set
                {
                    base[this.booksDataTable_0.pl_monthColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int pl_year
            {
                get
                {
                    return (int)base[this.booksDataTable_0.pl_yearColumn];
                }
                set
                {
                    base[this.booksDataTable_0.pl_yearColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string publish
            {
                get
                {
                    return (string)base[this.booksDataTable_0.publishColumn];
                }
                set
                {
                    base[this.booksDataTable_0.publishColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string translator
            {
                get
                {
                    return (string)base[this.booksDataTable_0.translatorColumn];
                }
                set
                {
                    base[this.booksDataTable_0.translatorColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int weight
            {
                get
                {
                    return (int)base[this.booksDataTable_0.weightColumn];
                }
                set
                {
                    base[this.booksDataTable_0.weightColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class BooksRowChangeEvent : EventArgs
        {
            private library_dataDataSet.BooksRow booksRow_0;
            private DataRowAction dataRowAction_0;

            static BooksRowChangeEvent()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BooksRowChangeEvent(library_dataDataSet.BooksRow row, DataRowAction action)
            {
                Class17.smethod_0();
                this.booksRow_0 = row;
                this.dataRowAction_0 = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.BooksRow Row
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void BooksRowChangeEventHandler(object sender, library_dataDataSet.BooksRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class merclocDataTable : DataTable, IEnumerable
        {
            private DataColumn dataColumn_0;
            private DataColumn dataColumn_1;
            private DataColumn dataColumn_2;
            private library_dataDataSet.merclocRowChangeEventHandler merclocRowChangeEventHandler_0;
            private library_dataDataSet.merclocRowChangeEventHandler merclocRowChangeEventHandler_1;
            private library_dataDataSet.merclocRowChangeEventHandler merclocRowChangeEventHandler_2;
            private library_dataDataSet.merclocRowChangeEventHandler merclocRowChangeEventHandler_3;
            private DataColumn wrrOadbVv;
            private DataColumn wZaclpluc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.merclocRowChangeEventHandler merclocRowChanged
            {
                add
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.merclocRowChangeEventHandler merclocRowChanging
            {
                add
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.merclocRowChangeEventHandler merclocRowDeleted
            {
                add
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.merclocRowChangeEventHandler merclocRowDeleting
            {
                add
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.merclocRowChangeEventHandler handler2;
                    library_dataDataSet.merclocRowChangeEventHandler handler = this.merclocRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.merclocRowChangeEventHandler handler3 = (library_dataDataSet.merclocRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.merclocRowChangeEventHandler>(ref this.merclocRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            static merclocDataTable()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public merclocDataTable()
            {
                Class17.smethod_0();
                base.TableName = "mercloc";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal merclocDataTable(DataTable table)
            {
                Class17.smethod_0();
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected merclocDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                Class17.smethod_0();
                this.method_0();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddmerclocRow(library_dataDataSet.merclocRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.merclocRow AddmerclocRow(string goods_id, string full_name, string grp_id, byte[] image, bool check)
            {
                library_dataDataSet.merclocRow row = (library_dataDataSet.merclocRow)base.NewRow();
                row.ItemArray = new object[] { goods_id, full_name, grp_id, image, check };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                library_dataDataSet.merclocDataTable table = (library_dataDataSet.merclocDataTable)base.Clone();
                table.method_0();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new library_dataDataSet.merclocDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.merclocRow FindBygoods_id(string goods_id)
            {
                return (library_dataDataSet.merclocRow)base.Rows.Find(new object[] { goods_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(library_dataDataSet.merclocRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                // This item is obfuscated and can not be translated.
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                library_dataDataSet set = new library_dataDataSet();
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
any2.MinOccurs = 1M;
                    any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name= "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "merclocDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length != stream2.Length)
                            {
                                continue;
                            }
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while (stream.Position == stream.Length)
                            {
                                if (0 == 0)
                                {
                                    goto Label_01C2;
                                }
                            }
                            goto Label_019A;
                        Label_01C2:
                            if (stream.Position == stream.Length)
                            {
                                return type;
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_0()
            {
                this.dataColumn_0 = base.Columns["goods_id"];
                this.dataColumn_1 = base.Columns["full_name"];
                this.wZaclpluc = base.Columns["grp_id"];
                this.dataColumn_2 = base.Columns["image"];
                this.wrrOadbVv = base.Columns["check"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_1()
            {
                this.dataColumn_0 = new DataColumn("goods_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_0);
                this.dataColumn_1 = new DataColumn("full_name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_1);
                this.wZaclpluc = new DataColumn("grp_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.wZaclpluc);
                this.dataColumn_2 = new DataColumn("image", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_2);
                this.wrrOadbVv = new DataColumn("check", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.wrrOadbVv);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.dataColumn_0 }, true));
                this.dataColumn_0.AllowDBNull = false;
                this.dataColumn_0.Unique = true;
                this.dataColumn_0.MaxLength = 6;
                this.dataColumn_1.AllowDBNull = false;
                this.dataColumn_1.MaxLength = 200;
                this.wZaclpluc.MaxLength = 50;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.merclocRow NewmerclocRow()
            {
                return (library_dataDataSet.merclocRow)base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new library_dataDataSet.merclocRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.merclocRowChangeEventHandler_1 != null)
                {
                    this.merclocRowChangeEventHandler_1(this, new library_dataDataSet.merclocRowChangeEvent((library_dataDataSet.merclocRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.merclocRowChangeEventHandler_0 != null)
                {
                    this.merclocRowChangeEventHandler_0(this, new library_dataDataSet.merclocRowChangeEvent((library_dataDataSet.merclocRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.merclocRowChangeEventHandler_3 != null)
                {
                    this.merclocRowChangeEventHandler_3(this, new library_dataDataSet.merclocRowChangeEvent((library_dataDataSet.merclocRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.merclocRowChangeEventHandler_2 != null)
                {
                    this.merclocRowChangeEventHandler_2(this, new library_dataDataSet.merclocRowChangeEvent((library_dataDataSet.merclocRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovemerclocRow(library_dataDataSet.merclocRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn checkColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn full_nameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn goods_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn grp_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn imageColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.merclocRow this[int index]
            {
                get
                {
                    return (library_dataDataSet.merclocRow)base.Rows[index];
                }
            }
        }

        public class merclocRow : DataRow
        {
            private library_dataDataSet.merclocDataTable merclocDataTable_0;

            static merclocRow()
            {
                Class15.smethod_5();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal merclocRow(DataRowBuilder rb)
                : base(rb)
            {
                Class17.smethod_0();
                this.merclocDataTable_0 = (library_dataDataSet.merclocDataTable)base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscheckNull()
            {
                return base.IsNull(this.merclocDataTable_0.checkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Isgrp_idNull()
            {
                return base.IsNull(this.merclocDataTable_0.grp_idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsimageNull()
            {
                return base.IsNull(this.merclocDataTable_0.imageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetcheckNull()
            {
                base[this.merclocDataTable_0.checkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setgrp_idNull()
            {
                base[this.merclocDataTable_0.grp_idColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetimageNull()
            {
                base[this.merclocDataTable_0.imageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool check
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool)base[this.merclocDataTable_0.checkColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'check' in table 'mercloc' is DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.merclocDataTable_0.checkColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string full_name
            {
                get
                {
                    return (string)base[this.merclocDataTable_0.full_nameColumn];
                }
                set
                {
                    base[this.merclocDataTable_0.full_nameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string goods_id
            {
                get
                {
                    return (string)base[this.merclocDataTable_0.goods_idColumn];
                }
                set
                {
                    base[this.merclocDataTable_0.goods_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string grp_id
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.merclocDataTable_0.grp_idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'grp_id' in table 'mercloc' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.merclocDataTable_0.grp_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public byte[] image
            {
                get
                {
                    byte[] buffer;
                    try
                    {
                        buffer = (byte[])base[this.merclocDataTable_0.imageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'image' in table 'mercloc' is DBNull.", exception);
                    }
                    return buffer;
                }
                set
                {
                    base[this.merclocDataTable_0.imageColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class merclocRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private library_dataDataSet.merclocRow merclocRow_0;

            static merclocRowChangeEvent()
            {
                Class15.smethod_5();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public merclocRowChangeEvent(library_dataDataSet.merclocRow row, DataRowAction action)
            {
                Class17.smethod_0();
                this.merclocRow_0 = row;
                this.dataRowAction_0 = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.merclocRow Row
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void merclocRowChangeEventHandler(object sender, library_dataDataSet.merclocRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblBookAttrDataTable : DataTable, IEnumerable
        {
            private DataColumn dataColumn_0;
            private DataColumn dataColumn_1;
            private DataColumn dataColumn_10;
            private DataColumn dataColumn_2;
            private DataColumn dataColumn_3;
            private DataColumn dataColumn_4;
            private DataColumn dataColumn_5;
            private DataColumn dataColumn_6;
            private DataColumn dataColumn_7;
            private DataColumn dataColumn_8;
            private DataColumn dataColumn_9;
            private DataColumn pfeZyQnoF;
            private library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowChangeEventHandler_0;
            private library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowChangeEventHandler_1;
            private library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowChangeEventHandler_2;
            private library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowChangeEventHandler_3;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowChanged
            {
                add
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowChanging
            {
                add
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowDeleted
            {
                add
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblBookAttrRowChangeEventHandler tblBookAttrRowDeleting
            {
                add
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler2;
                    library_dataDataSet.tblBookAttrRowChangeEventHandler handler = this.tblBookAttrRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblBookAttrRowChangeEventHandler handler3 = (library_dataDataSet.tblBookAttrRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblBookAttrRowChangeEventHandler>(ref this.tblBookAttrRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            static tblBookAttrDataTable()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblBookAttrDataTable()
            {
                Class17.smethod_0();
                base.TableName = "tblBookAttr";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblBookAttrDataTable(DataTable table)
            {
                Class17.smethod_0();
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tblBookAttrDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                Class17.smethod_0();
                this.method_0();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void AddtblBookAttrRow(library_dataDataSet.tblBookAttrRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.tblBookAttrRow AddtblBookAttrRow(string goods_id, string author, string publish, string translator, int form_type, int language, int pl_month, int pl_year, string dimension, int weight, int pages, string introinfo)
            {
                library_dataDataSet.tblBookAttrRow row = (library_dataDataSet.tblBookAttrRow)base.NewRow();
                row.ItemArray = new object[] { goods_id, author, publish, translator, form_type, language, pl_month, pl_year, dimension, weight, pages, introinfo };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                library_dataDataSet.tblBookAttrDataTable table = (library_dataDataSet.tblBookAttrDataTable)base.Clone();
                table.method_0();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new library_dataDataSet.tblBookAttrDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblBookAttrRow FindBygoods_id(string goods_id)
            {
                return (library_dataDataSet.tblBookAttrRow)base.Rows.Find(new object[] { goods_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(library_dataDataSet.tblBookAttrRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                // This item is obfuscated and can not be translated.
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                library_dataDataSet set = new library_dataDataSet();
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny ();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "tblBookAttrDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length != stream2.Length)
                            {
                                continue;
                            }
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while (stream.Position == stream.Length)
                            {
                                if (0 == 0)
                                {
                                    goto Label_01C2;
                                }
                            }
                            goto Label_019A;
                        Label_01C2:
                            if (stream.Position == stream.Length)
                            {
                                return type;
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_0()
            {
                this.dataColumn_0 = base.Columns["goods_id"];
                this.dataColumn_1 = base.Columns["author"];
                this.dataColumn_2 = base.Columns["publish"];
                this.dataColumn_3 = base.Columns["translator"];
                this.dataColumn_4 = base.Columns["form_type"];
                this.dataColumn_5 = base.Columns["language"];
                this.pfeZyQnoF = base.Columns["pl_month"];
                this.dataColumn_6 = base.Columns["pl_year"];
                this.dataColumn_7 = base.Columns["dimension"];
                this.dataColumn_8 = base.Columns["weight"];
                this.dataColumn_9 = base.Columns["pages"];
                this.dataColumn_10 = base.Columns["introinfo"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_1()
            {
                this.dataColumn_0 = new DataColumn("goods_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_0);
                this.dataColumn_1 = new DataColumn("author", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_1);
                this.dataColumn_2 = new DataColumn("publish", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_2);
                this.dataColumn_3 = new DataColumn("translator", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_3);
                this.dataColumn_4 = new DataColumn("form_type", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_4);
                this.dataColumn_5 = new DataColumn("language", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_5);
                this.pfeZyQnoF = new DataColumn("pl_month", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.pfeZyQnoF);
                this.dataColumn_6 = new DataColumn("pl_year", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_6);
                this.dataColumn_7 = new DataColumn("dimension", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_7);
                this.dataColumn_8 = new DataColumn("weight", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_8);
                this.dataColumn_9 = new DataColumn("pages", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_9);
                this.dataColumn_10 = new DataColumn("introinfo", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_10);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.dataColumn_0 }, true));
                this.dataColumn_0.AllowDBNull = false;
                this.dataColumn_0.Unique = true;
                this.dataColumn_0.MaxLength = 6;
                this.dataColumn_1.AllowDBNull = false;
                this.dataColumn_1.MaxLength = 200;
                this.dataColumn_2.AllowDBNull = false;
                this.dataColumn_2.MaxLength = 200;
                this.dataColumn_3.AllowDBNull = false;
                this.dataColumn_3.MaxLength = 200;
                this.dataColumn_4.AllowDBNull = false;
                this.dataColumn_5.AllowDBNull = false;
                this.pfeZyQnoF.AllowDBNull = false;
                this.dataColumn_6.AllowDBNull = false;
                this.dataColumn_7.AllowDBNull = false;
                this.dataColumn_7.MaxLength = 100;
                this.dataColumn_8.AllowDBNull = false;
                this.dataColumn_9.AllowDBNull = false;
                this.dataColumn_10.AllowDBNull = false;
                this.dataColumn_10.MaxLength = 0x5dc;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new library_dataDataSet.tblBookAttrRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.tblBookAttrRow NewtblBookAttrRow()
            {
                return (library_dataDataSet.tblBookAttrRow)base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tblBookAttrRowChangeEventHandler_1 != null)
                {
                    this.tblBookAttrRowChangeEventHandler_1(this, new library_dataDataSet.tblBookAttrRowChangeEvent((library_dataDataSet.tblBookAttrRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tblBookAttrRowChangeEventHandler_0 != null)
                {
                    this.tblBookAttrRowChangeEventHandler_0(this, new library_dataDataSet.tblBookAttrRowChangeEvent((library_dataDataSet.tblBookAttrRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tblBookAttrRowChangeEventHandler_3 != null)
                {
                    this.tblBookAttrRowChangeEventHandler_3(this, new library_dataDataSet.tblBookAttrRowChangeEvent((library_dataDataSet.tblBookAttrRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tblBookAttrRowChangeEventHandler_2 != null)
                {
                    this.tblBookAttrRowChangeEventHandler_2(this, new library_dataDataSet.tblBookAttrRowChangeEvent((library_dataDataSet.tblBookAttrRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovetblBookAttrRow(library_dataDataSet.tblBookAttrRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn authorColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dimensionColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn form_typeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn goods_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn introinfoColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.tblBookAttrRow this[int index]
            {
                get
                {
                    return (library_dataDataSet.tblBookAttrRow)base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn languageColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn pagesColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn pl_monthColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn pl_yearColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn publishColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn translatorColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn weightColumn
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        public class tblBookAttrRow : DataRow
        {
            private library_dataDataSet.tblBookAttrDataTable tblBookAttrDataTable_0;

            static tblBookAttrRow()
            {
                Class15.smethod_5();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblBookAttrRow(DataRowBuilder rb)
                : base(rb)
            {
                Class17.smethod_0();
                this.tblBookAttrDataTable_0 = (library_dataDataSet.tblBookAttrDataTable)base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string author
            {
                get
                {
                    return (string)base[this.tblBookAttrDataTable_0.authorColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.authorColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string dimension
            {
                get
                {
                    return (string)base[this.tblBookAttrDataTable_0.dimensionColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.dimensionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int form_type
            {
                get
                {
                    return (int)base[this.tblBookAttrDataTable_0.form_typeColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.form_typeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string goods_id
            {
                get
                {
                    return (string)base[this.tblBookAttrDataTable_0.goods_idColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.goods_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string introinfo
            {
                get
                {
                    return (string)base[this.tblBookAttrDataTable_0.introinfoColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.introinfoColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int language
            {
                get
                {
                    return (int)base[this.tblBookAttrDataTable_0.languageColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.languageColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int pages
            {
                get
                {
                    return (int)base[this.tblBookAttrDataTable_0.pagesColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.pagesColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int pl_month
            {
                get
                {
                    return (int)base[this.tblBookAttrDataTable_0.pl_monthColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.pl_monthColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int pl_year
            {
                get
                {
                    return (int)base[this.tblBookAttrDataTable_0.pl_yearColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.pl_yearColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string publish
            {
                get
                {
                    return (string)base[this.tblBookAttrDataTable_0.publishColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.publishColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string translator
            {
                get
                {
                    return (string)base[this.tblBookAttrDataTable_0.translatorColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.translatorColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int weight
            {
                get
                {
                    return (int)base[this.tblBookAttrDataTable_0.weightColumn];
                }
                set
                {
                    base[this.tblBookAttrDataTable_0.weightColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tblBookAttrRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private library_dataDataSet.tblBookAttrRow tblBookAttrRow_0;

            static tblBookAttrRowChangeEvent()
            {
                Class15.smethod_5();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblBookAttrRowChangeEvent(library_dataDataSet.tblBookAttrRow row, DataRowAction action)
            {
                Class17.smethod_0();
                this.tblBookAttrRow_0 = row;
                this.dataRowAction_0 = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblBookAttrRow Row
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tblBookAttrRowChangeEventHandler(object sender, library_dataDataSet.tblBookAttrRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblCustomerDataTable : DataTable, IEnumerable
        {
            private DataColumn dataColumn_0;
            private DataColumn dataColumn_1;
            private DataColumn dataColumn_10;
            private DataColumn dataColumn_11;
            private DataColumn dataColumn_12;
            private DataColumn dataColumn_13;
            private DataColumn dataColumn_14;
            private DataColumn dataColumn_15;
            private DataColumn dataColumn_16;
            private DataColumn dataColumn_2;
            private DataColumn dataColumn_3;
            private DataColumn dataColumn_4;
            private DataColumn dataColumn_5;
            private DataColumn dataColumn_6;
            private DataColumn dataColumn_7;
            private DataColumn dataColumn_8;
            private DataColumn dataColumn_9;
            private library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowChangeEventHandler_0;
            private library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowChangeEventHandler_1;
            private library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowChangeEventHandler_2;
            private library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowChangeEventHandler_3;
            private DataColumn wrrOadbVv;
            private DataColumn wZaclpluc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowChanged
            {
                add
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowChanging
            {
                add
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowDeleted
            {
                add
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblCustomerRowChangeEventHandler tblCustomerRowDeleting
            {
                add
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler2;
                    library_dataDataSet.tblCustomerRowChangeEventHandler handler = this.tblCustomerRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblCustomerRowChangeEventHandler handler3 = (library_dataDataSet.tblCustomerRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblCustomerRowChangeEventHandler>(ref this.tblCustomerRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            static tblCustomerDataTable()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblCustomerDataTable()
            {
                Class17.smethod_0();
                base.TableName = "tblCustomer";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblCustomerDataTable(DataTable table)
            {
                Class17.smethod_0();
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tblCustomerDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                Class17.smethod_0();
                this.method_0();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddtblCustomerRow(library_dataDataSet.tblCustomerRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblCustomerRow AddtblCustomerRow(string id, int Type, string fullname, string address, string phone, string fax, string person_id, string place_issue, string email, DateTime due_date, byte[] image, string bankname, string bank_br, string accnum, string Vatnum, string contactps, string remark, DateTime open_date, bool Status)
            {
                library_dataDataSet.tblCustomerRow row = (library_dataDataSet.tblCustomerRow)base.NewRow();
                row.ItemArray = new object[] { 
                    id, Type, fullname, address, phone, fax, person_id, place_issue, email, due_date, image, bankname, bank_br, accnum, Vatnum, contactps, 
                    remark, open_date, Status
                 };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                library_dataDataSet.tblCustomerDataTable table = (library_dataDataSet.tblCustomerDataTable)base.Clone();
                table.method_0();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new library_dataDataSet.tblCustomerDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.tblCustomerRow FindByid(string id)
            {
                return (library_dataDataSet.tblCustomerRow)base.Rows.Find(new object[] { id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(library_dataDataSet.tblCustomerRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                // This item is obfuscated and can not be translated.
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                library_dataDataSet set = new library_dataDataSet();
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                    any2.MinOccurs = 1M;
                    any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                    attribute.Name = "namespace";
                    attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "tblCustomerDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length != stream2.Length)
                            {
                                continue;
                            }
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while (stream.Position == stream.Length)
                            {
                                if (0 == 0)
                                {
                                    goto Label_01C2;
                                }
                            }
                            goto Label_019A;
                        Label_01C2:
                            if (stream.Position == stream.Length)
                            {
                                return type;
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_0()
            {
                this.dataColumn_0 = base.Columns["id"];
                this.dataColumn_1 = base.Columns["Type"];
                this.wZaclpluc = base.Columns["fullname"];
                this.dataColumn_2 = base.Columns["address"];
                this.wrrOadbVv = base.Columns["phone"];
                this.dataColumn_3 = base.Columns["fax"];
                this.dataColumn_4 = base.Columns["person_id"];
                this.dataColumn_5 = base.Columns["place_issue"];
                this.dataColumn_6 = base.Columns["email"];
                this.dataColumn_7 = base.Columns["due_date"];
                this.dataColumn_8 = base.Columns["image"];
                this.dataColumn_9 = base.Columns["bankname"];
                this.dataColumn_10 = base.Columns["bank_br"];
                this.dataColumn_11 = base.Columns["accnum"];
                this.dataColumn_12 = base.Columns["Vatnum"];
                this.dataColumn_13 = base.Columns["contactps"];
                this.dataColumn_14 = base.Columns["remark"];
                this.dataColumn_15 = base.Columns["open_date"];
                this.dataColumn_16 = base.Columns["Status"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_1()
            {
                this.dataColumn_0 = new DataColumn("id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_0);
                this.dataColumn_1 = new DataColumn("Type", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_1);
                this.wZaclpluc = new DataColumn("fullname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.wZaclpluc);
                this.dataColumn_2 = new DataColumn("address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_2);
                this.wrrOadbVv = new DataColumn("phone", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.wrrOadbVv);
                this.dataColumn_3 = new DataColumn("fax", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_3);
                this.dataColumn_4 = new DataColumn("person_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_4);
                this.dataColumn_5 = new DataColumn("place_issue", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_5);
                this.dataColumn_6 = new DataColumn("email", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_6);
                this.dataColumn_7 = new DataColumn("due_date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_7);
                this.dataColumn_8 = new DataColumn("image", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_8);
                this.dataColumn_9 = new DataColumn("bankname", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_9);
                this.dataColumn_10 = new DataColumn("bank_br", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_10);
                this.dataColumn_11 = new DataColumn("accnum", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_11);
                this.dataColumn_12 = new DataColumn("Vatnum", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_12);
                this.dataColumn_13 = new DataColumn("contactps", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_13);
                this.dataColumn_14 = new DataColumn("remark", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_14);
                this.dataColumn_15 = new DataColumn("open_date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_15);
                this.dataColumn_16 = new DataColumn("Status", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_16);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.dataColumn_0 }, true));
                this.dataColumn_0.AllowDBNull = false;
                this.dataColumn_0.Unique = true;
                this.dataColumn_0.MaxLength = 8;
                this.wZaclpluc.MaxLength = 200;
                this.dataColumn_2.MaxLength = 500;
                this.wrrOadbVv.MaxLength = 100;
                this.dataColumn_3.MaxLength = 50;
                this.dataColumn_4.MaxLength = 30;
                this.dataColumn_5.MaxLength = 150;
                this.dataColumn_6.MaxLength = 100;
                this.dataColumn_9.MaxLength = 150;
                this.dataColumn_10.MaxLength = 150;
                this.dataColumn_11.MaxLength = 50;
                this.dataColumn_12.MaxLength = 50;
                this.dataColumn_13.MaxLength = 50;
                this.dataColumn_14.MaxLength = 500;
                this.dataColumn_16.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new library_dataDataSet.tblCustomerRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblCustomerRow NewtblCustomerRow()
            {
                return (library_dataDataSet.tblCustomerRow)base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tblCustomerRowChangeEventHandler_1 != null)
                {
                    this.tblCustomerRowChangeEventHandler_1(this, new library_dataDataSet.tblCustomerRowChangeEvent((library_dataDataSet.tblCustomerRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tblCustomerRowChangeEventHandler_0 != null)
                {
                    this.tblCustomerRowChangeEventHandler_0(this, new library_dataDataSet.tblCustomerRowChangeEvent((library_dataDataSet.tblCustomerRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tblCustomerRowChangeEventHandler_3 != null)
                {
                    this.tblCustomerRowChangeEventHandler_3(this, new library_dataDataSet.tblCustomerRowChangeEvent((library_dataDataSet.tblCustomerRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tblCustomerRowChangeEventHandler_2 != null)
                {
                    this.tblCustomerRowChangeEventHandler_2(this, new library_dataDataSet.tblCustomerRowChangeEvent((library_dataDataSet.tblCustomerRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void RemovetblCustomerRow(library_dataDataSet.tblCustomerRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn accnumColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn addressColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn bank_brColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn banknameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn contactpsColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn due_dateColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn emailColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn faxColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn fullnameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn imageColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblCustomerRow this[int index]
            {
                get
                {
                    return (library_dataDataSet.tblCustomerRow)base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn open_dateColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn person_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn phoneColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn place_issueColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn remarkColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn StatusColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn VatnumColumn
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        public class tblCustomerRow : DataRow
        {
            private library_dataDataSet.tblCustomerDataTable tblCustomerDataTable_0;

            static tblCustomerRow()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblCustomerRow(DataRowBuilder rb)
                : base(rb)
            {
                Class17.smethod_0();
                this.tblCustomerDataTable_0 = (library_dataDataSet.tblCustomerDataTable)base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsaccnumNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.accnumColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsaddressNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.addressColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Isbank_brNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.bank_brColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsbanknameNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.banknameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscontactpsNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.contactpsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isdue_dateNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.due_dateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsemailNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.emailColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsfaxNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.faxColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsfullnameNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.fullnameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsimageNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.imageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isopen_dateNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.open_dateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isperson_idNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.person_idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsphoneNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.phoneColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isplace_issueNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.place_issueColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsremarkNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.remarkColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTypeNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.TypeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsVatnumNull()
            {
                return base.IsNull(this.tblCustomerDataTable_0.VatnumColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetaccnumNull()
            {
                base[this.tblCustomerDataTable_0.accnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetaddressNull()
            {
                base[this.tblCustomerDataTable_0.addressColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setbank_brNull()
            {
                base[this.tblCustomerDataTable_0.bank_brColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetbanknameNull()
            {
                base[this.tblCustomerDataTable_0.banknameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetcontactpsNull()
            {
                base[this.tblCustomerDataTable_0.contactpsColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setdue_dateNull()
            {
                base[this.tblCustomerDataTable_0.due_dateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetemailNull()
            {
                base[this.tblCustomerDataTable_0.emailColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetfaxNull()
            {
                base[this.tblCustomerDataTable_0.faxColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetfullnameNull()
            {
                base[this.tblCustomerDataTable_0.fullnameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetimageNull()
            {
                base[this.tblCustomerDataTable_0.imageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setopen_dateNull()
            {
                base[this.tblCustomerDataTable_0.open_dateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setperson_idNull()
            {
                base[this.tblCustomerDataTable_0.person_idColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetphoneNull()
            {
                base[this.tblCustomerDataTable_0.phoneColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setplace_issueNull()
            {
                base[this.tblCustomerDataTable_0.place_issueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetremarkNull()
            {
                base[this.tblCustomerDataTable_0.remarkColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTypeNull()
            {
                base[this.tblCustomerDataTable_0.TypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetVatnumNull()
            {
                base[this.tblCustomerDataTable_0.VatnumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string accnum
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.accnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'accnum' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.accnumColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string address
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.addressColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'address' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.addressColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string bank_br
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.bank_brColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'bank_br' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.bank_brColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string bankname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.banknameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'bankname' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.banknameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string contactps
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.contactpsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'contactps' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.contactpsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime due_date
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime)base[this.tblCustomerDataTable_0.due_dateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'due_date' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.due_dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string email
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.emailColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'email' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.emailColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string fax
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.faxColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'fax' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.faxColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string fullname
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.fullnameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'fullname' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.fullnameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string id
            {
                get
                {
                    return (string)base[this.tblCustomerDataTable_0.idColumn];
                }
                set
                {
                    base[this.tblCustomerDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public byte[] image
            {
                get
                {
                    byte[] buffer;
                    try
                    {
                        buffer = (byte[])base[this.tblCustomerDataTable_0.imageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'image' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return buffer;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.imageColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime open_date
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime)base[this.tblCustomerDataTable_0.open_dateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'open_date' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.open_dateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string person_id
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.person_idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'person_id' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.person_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string phone
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.phoneColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'phone' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.phoneColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string place_issue
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.place_issueColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'place_issue' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.place_issueColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string remark
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.remarkColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'remark' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.remarkColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Status
            {
                get
                {
                    return (bool)base[this.tblCustomerDataTable_0.StatusColumn];
                }
                set
                {
                    base[this.tblCustomerDataTable_0.StatusColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Type
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int)base[this.tblCustomerDataTable_0.TypeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Type' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.TypeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Vatnum
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblCustomerDataTable_0.VatnumColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Vatnum' in table 'tblCustomer' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblCustomerDataTable_0.VatnumColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tblCustomerRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private library_dataDataSet.tblCustomerRow tblCustomerRow_0;

            static tblCustomerRowChangeEvent()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblCustomerRowChangeEvent(library_dataDataSet.tblCustomerRow row, DataRowAction action)
            {
                Class17.smethod_0();
                this.tblCustomerRow_0 = row;
                this.dataRowAction_0 = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.tblCustomerRow Row
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tblCustomerRowChangeEventHandler(object sender, library_dataDataSet.tblCustomerRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblGoodsDataTable : DataTable, IEnumerable
        {
            private DataColumn dataColumn_0;
            private DataColumn dataColumn_1;
            private DataColumn dataColumn_10;
            private DataColumn dataColumn_11;
            private DataColumn dataColumn_12;
            private DataColumn dataColumn_13;
            private DataColumn dataColumn_14;
            private DataColumn dataColumn_15;
            private DataColumn dataColumn_16;
            private DataColumn dataColumn_2;
            private DataColumn dataColumn_3;
            private DataColumn dataColumn_4;
            private DataColumn dataColumn_5;
            private DataColumn dataColumn_6;
            private DataColumn dataColumn_7;
            private DataColumn dataColumn_8;
            private DataColumn dataColumn_9;
            private library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowChangeEventHandler_0;
            private library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowChangeEventHandler_1;
            private library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowChangeEventHandler_2;
            private library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowChangeEventHandler_3;
            private DataColumn wrrOadbVv;
            private DataColumn wZaclpluc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowChanged
            {
                add
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_1;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_1, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowChanging
            {
                add
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_0;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_0, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowDeleted
            {
                add
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_3;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_3, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event library_dataDataSet.tblGoodsRowChangeEventHandler tblGoodsRowDeleting
            {
                add
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Combine(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
                remove
                {
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler2;
                    library_dataDataSet.tblGoodsRowChangeEventHandler handler = this.tblGoodsRowChangeEventHandler_2;
                    do
                    {
                        handler2 = handler;
                        library_dataDataSet.tblGoodsRowChangeEventHandler handler3 = (library_dataDataSet.tblGoodsRowChangeEventHandler)Delegate.Remove(handler2, value);
                        handler = Interlocked.CompareExchange<library_dataDataSet.tblGoodsRowChangeEventHandler>(ref this.tblGoodsRowChangeEventHandler_2, handler3, handler2);
                    }
                    while (handler != handler2);
                }
            }

            static tblGoodsDataTable()
            {
                Class15.smethod_5();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblGoodsDataTable()
            {
                Class17.smethod_0();
                base.TableName = "tblGoods";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblGoodsDataTable(DataTable table)
            {
                Class17.smethod_0();
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tblGoodsDataTable(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
                Class17.smethod_0();
                this.method_0();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void AddtblGoodsRow(library_dataDataSet.tblGoodsRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblGoodsRow AddtblGoodsRow(string goods_id, string barcode, bool mbc, string _ref, string grp_id, string short_name, string full_name, string packunit, string piceunit, decimal unitconv, string supp_id, byte[] image, DateTime open_date, string tax_code, string merc_type, string attr_type, bool domestic, bool warranty, bool status)
            {
                library_dataDataSet.tblGoodsRow row = (library_dataDataSet.tblGoodsRow)base.NewRow();
                row.ItemArray = new object[] { 
                    goods_id, barcode, mbc, _ref, grp_id, short_name, full_name, packunit, piceunit, unitconv, supp_id, image, open_date, tax_code, merc_type, attr_type, 
                    domestic, warranty, status
                 };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                library_dataDataSet.tblGoodsDataTable table = (library_dataDataSet.tblGoodsDataTable)base.Clone();
                table.method_0();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new library_dataDataSet.tblGoodsDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblGoodsRow FindBygoods_id(string goods_id)
            {
                return (library_dataDataSet.tblGoodsRow)base.Rows.Find(new object[] { goods_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public virtual IEnumerator GetEnumerator()
            {
                return base.Rows.GetEnumerator();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(library_dataDataSet.tblGoodsRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                // This item is obfuscated and can not be translated.
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                library_dataDataSet set = new library_dataDataSet();
                XmlSchemaAny item = new XmlSchemaAny();
                item.Namespace = "http://www.w3.org/2001/XMLSchema";
                item.MinOccurs = 0M;
                item.MaxOccurs = 79228162514264337593543950335M;
                item.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = 1M;
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute();
                attribute.Name = "namespace";
                attribute.FixedValue = set.Namespace;
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "tblGoodsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length != stream2.Length)
                            {
                                continue;
                            }
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while (stream.Position == stream.Length)
                            {
                                if (0 == 0)
                                {
                                    goto Label_01C2;
                                }
                            }
                            goto Label_019A;
                        Label_01C2:
                            if (stream.Position == stream.Length)
                            {
                                return type;
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_0()
            {
                this.dataColumn_0 = base.Columns["goods_id"];
                this.dataColumn_1 = base.Columns["barcode"];
                this.wZaclpluc = base.Columns["mbc"];
                this.dataColumn_2 = base.Columns["ref"];
                this.wrrOadbVv = base.Columns["grp_id"];
                this.dataColumn_3 = base.Columns["short_name"];
                this.dataColumn_4 = base.Columns["full_name"];
                this.dataColumn_5 = base.Columns["packunit"];
                this.dataColumn_6 = base.Columns["piceunit"];
                this.dataColumn_7 = base.Columns["unitconv"];
                this.dataColumn_8 = base.Columns["supp_id"];
                this.dataColumn_9 = base.Columns["image"];
                this.dataColumn_10 = base.Columns["open_date"];
                this.dataColumn_11 = base.Columns["tax_code"];
                this.dataColumn_12 = base.Columns["merc_type"];
                this.dataColumn_13 = base.Columns["attr_type"];
                this.dataColumn_14 = base.Columns["domestic"];
                this.dataColumn_15 = base.Columns["warranty"];
                this.dataColumn_16 = base.Columns["status"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_1()
            {
                this.dataColumn_0 = new DataColumn("goods_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_0);
                this.dataColumn_1 = new DataColumn("barcode", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_1);
                this.wZaclpluc = new DataColumn("mbc", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.wZaclpluc);
                this.dataColumn_2 = new DataColumn("ref", typeof(string), null, MappingType.Element);
                this.dataColumn_2.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "refColumn");
                this.dataColumn_2.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnref");
                this.dataColumn_2.ExtendedProperties.Add("Generator_UserColumnName", "ref");
                base.Columns.Add(this.dataColumn_2);
                this.wrrOadbVv = new DataColumn("grp_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.wrrOadbVv);
                this.dataColumn_3 = new DataColumn("short_name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_3);
                this.dataColumn_4 = new DataColumn("full_name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_4);
                this.dataColumn_5 = new DataColumn("packunit", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_5);
                this.dataColumn_6 = new DataColumn("piceunit", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_6);
                this.dataColumn_7 = new DataColumn("unitconv", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_7);
                this.dataColumn_8 = new DataColumn("supp_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_8);
                this.dataColumn_9 = new DataColumn("image", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_9);
                this.dataColumn_10 = new DataColumn("open_date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_10);
                this.dataColumn_11 = new DataColumn("tax_code", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_11);
                this.dataColumn_12 = new DataColumn("merc_type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_12);
                this.dataColumn_13 = new DataColumn("attr_type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_13);
                this.dataColumn_14 = new DataColumn("domestic", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_14);
                this.dataColumn_15 = new DataColumn("warranty", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_15);
                this.dataColumn_16 = new DataColumn("status", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.dataColumn_16);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.dataColumn_0 }, true));
                this.dataColumn_0.AllowDBNull = false;
                this.dataColumn_0.Unique = true;
                this.dataColumn_0.MaxLength = 6;
                this.dataColumn_1.AllowDBNull = false;
                this.dataColumn_1.MaxLength = 20;
                this.wZaclpluc.AllowDBNull = false;
                this.dataColumn_2.MaxLength = 10;
                this.wrrOadbVv.MaxLength = 50;
                this.dataColumn_3.AllowDBNull = false;
                this.dataColumn_3.MaxLength = 100;
                this.dataColumn_4.AllowDBNull = false;
                this.dataColumn_4.MaxLength = 200;
                this.dataColumn_5.AllowDBNull = false;
                this.dataColumn_5.MaxLength = 3;
                this.dataColumn_6.AllowDBNull = false;
                this.dataColumn_6.MaxLength = 3;
                this.dataColumn_7.AllowDBNull = false;
                this.dataColumn_8.MaxLength = 5;
                this.dataColumn_11.MaxLength = 3;
                this.dataColumn_12.MaxLength = 2;
                this.dataColumn_13.MaxLength = 2;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new library_dataDataSet.tblGoodsRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblGoodsRow NewtblGoodsRow()
            {
                return (library_dataDataSet.tblGoodsRow)base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tblGoodsRowChangeEventHandler_1 != null)
                {
                    this.tblGoodsRowChangeEventHandler_1(this, new library_dataDataSet.tblGoodsRowChangeEvent((library_dataDataSet.tblGoodsRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tblGoodsRowChangeEventHandler_0 != null)
                {
                    this.tblGoodsRowChangeEventHandler_0(this, new library_dataDataSet.tblGoodsRowChangeEvent((library_dataDataSet.tblGoodsRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tblGoodsRowChangeEventHandler_3 != null)
                {
                    this.tblGoodsRowChangeEventHandler_3(this, new library_dataDataSet.tblGoodsRowChangeEvent((library_dataDataSet.tblGoodsRow)e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tblGoodsRowChangeEventHandler_2 != null)
                {
                    this.tblGoodsRowChangeEventHandler_2(this, new library_dataDataSet.tblGoodsRowChangeEvent((library_dataDataSet.tblGoodsRow)e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void RemovetblGoodsRow(library_dataDataSet.tblGoodsRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn attr_typeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn barcodeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn domesticColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn full_nameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn goods_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn grp_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn imageColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public library_dataDataSet.tblGoodsRow this[int index]
            {
                get
                {
                    return (library_dataDataSet.tblGoodsRow)base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn mbcColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn merc_typeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn open_dateColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn packunitColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn piceunitColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn refColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn short_nameColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn statusColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn supp_idColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn tax_codeColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn unitconvColumn
            {
                get
                {
                    throw -559038242;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn warrantyColumn
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        public class tblGoodsRow : DataRow
        {
            private library_dataDataSet.tblGoodsDataTable tblGoodsDataTable_0;

            static tblGoodsRow()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblGoodsRow(DataRowBuilder rb)
                : base(rb)
            {
                Class17.smethod_0();
                this.tblGoodsDataTable_0 = (library_dataDataSet.tblGoodsDataTable)base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Is_refNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.refColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Isattr_typeNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.attr_typeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsdomesticNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.domesticColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isgrp_idNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.grp_idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsimageNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.imageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Ismerc_typeNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.merc_typeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isopen_dateNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.open_dateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsstatusNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.statusColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Issupp_idNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.supp_idColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Istax_codeNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.tax_codeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IswarrantyNull()
            {
                return base.IsNull(this.tblGoodsDataTable_0.warrantyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Set_refNull()
            {
                base[this.tblGoodsDataTable_0.refColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setattr_typeNull()
            {
                base[this.tblGoodsDataTable_0.attr_typeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetdomesticNull()
            {
                base[this.tblGoodsDataTable_0.domesticColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setgrp_idNull()
            {
                base[this.tblGoodsDataTable_0.grp_idColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetimageNull()
            {
                base[this.tblGoodsDataTable_0.imageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setmerc_typeNull()
            {
                base[this.tblGoodsDataTable_0.merc_typeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setopen_dateNull()
            {
                base[this.tblGoodsDataTable_0.open_dateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetstatusNull()
            {
                base[this.tblGoodsDataTable_0.statusColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setsupp_idNull()
            {
                base[this.tblGoodsDataTable_0.supp_idColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Settax_codeNull()
            {
                base[this.tblGoodsDataTable_0.tax_codeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetwarrantyNull()
            {
                base[this.tblGoodsDataTable_0.warrantyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string _ref
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblGoodsDataTable_0.refColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ref' in table 'tblGoods' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.refColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string attr_type
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblGoodsDataTable_0.attr_typeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'attr_type' in table 'tblGoods' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.attr_typeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string barcode
            {
                get
                {
                    return (string)base[this.tblGoodsDataTable_0.barcodeColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.barcodeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool domestic
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool)base[this.tblGoodsDataTable_0.domesticColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'domestic' in table 'tblGoods' is DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.domesticColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string full_name
            {
                get
                {
                    return (string)base[this.tblGoodsDataTable_0.full_nameColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.full_nameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string goods_id
            {
                get
                {
                    return (string)base[this.tblGoodsDataTable_0.goods_idColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.goods_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string grp_id
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblGoodsDataTable_0.grp_idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'grp_id' in table 'tblGoods' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.grp_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte[] image
            {
                get
                {
                    byte[] buffer;
                    try
                    {
                        buffer = (byte[])base[this.tblGoodsDataTable_0.imageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'image' in table 'tblGoods' is DBNull.", exception);
                    }
                    return buffer;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.imageColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool mbc
            {
                get
                {
                    return (bool)base[this.tblGoodsDataTable_0.mbcColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.mbcColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string merc_type
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblGoodsDataTable_0.merc_typeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'merc_type' in table 'tblGoods' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.merc_typeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime open_date
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime)base[this.tblGoodsDataTable_0.open_dateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'open_date' in table 'tblGoods' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.open_dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string packunit
            {
                get
                {
                    return (string)base[this.tblGoodsDataTable_0.packunitColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.packunitColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string piceunit
            {
                get
                {
                    return (string)base[this.tblGoodsDataTable_0.piceunitColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.piceunitColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string short_name
            {
                get
                {
                    return (string)base[this.tblGoodsDataTable_0.short_nameColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.short_nameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool status
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool)base[this.tblGoodsDataTable_0.statusColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'status' in table 'tblGoods' is DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.statusColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string supp_id
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblGoodsDataTable_0.supp_idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'supp_id' in table 'tblGoods' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.supp_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string tax_code
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string)base[this.tblGoodsDataTable_0.tax_codeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'tax_code' in table 'tblGoods' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.tax_codeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal unitconv
            {
                get
                {
                    return (decimal)base[this.tblGoodsDataTable_0.unitconvColumn];
                }
                set
                {
                    base[this.tblGoodsDataTable_0.unitconvColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool warranty
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool)base[this.tblGoodsDataTable_0.warrantyColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'warranty' in table 'tblGoods' is DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblGoodsDataTable_0.warrantyColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tblGoodsRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private library_dataDataSet.tblGoodsRow tblGoodsRow_0;

            static tblGoodsRowChangeEvent()
            {
                Class15.smethod_5();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblGoodsRowChangeEvent(library_dataDataSet.tblGoodsRow row, DataRowAction action)
            {
                Class17.smethod_0();
                this.tblGoodsRow_0 = row;
                this.dataRowAction_0 = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    throw -559038242;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public library_dataDataSet.tblGoodsRow Row
            {
                get
                {
                    throw -559038242;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tblGoodsRowChangeEventHandler(object sender, library_dataDataSet.tblGoodsRowChangeEvent e);
    }
}

