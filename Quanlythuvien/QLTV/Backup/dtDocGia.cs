﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Quanlythuvien {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dtDocGia : DataSet {
        
        private DOCGIADataTable tableDOCGIA;
        
        public dtDocGia() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dtDocGia(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["DOCGIA"] != null)) {
                    this.Tables.Add(new DOCGIADataTable(ds.Tables["DOCGIA"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public DOCGIADataTable DOCGIA {
            get {
                return this.tableDOCGIA;
            }
        }
        
        public override DataSet Clone() {
            dtDocGia cln = ((dtDocGia)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["DOCGIA"] != null)) {
                this.Tables.Add(new DOCGIADataTable(ds.Tables["DOCGIA"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableDOCGIA = ((DOCGIADataTable)(this.Tables["DOCGIA"]));
            if ((this.tableDOCGIA != null)) {
                this.tableDOCGIA.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dtDocGia";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dtDocGia.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableDOCGIA = new DOCGIADataTable();
            this.Tables.Add(this.tableDOCGIA);
        }
        
        private bool ShouldSerializeDOCGIA() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void DOCGIARowChangeEventHandler(object sender, DOCGIARowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DOCGIADataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnMSDG;
            
            private DataColumn columnTENDG;
            
            private DataColumn columnDIACHI;
            
            private DataColumn columnNGAYSINH;
            
            private DataColumn columnEMAIL;
            
            private DataColumn columnGIOITINH;
            
            private DataColumn columnTHONGTINKHAC;
            
            private DataColumn columnHINHANHDG;
            
            internal DOCGIADataTable() : 
                    base("DOCGIA") {
                this.InitClass();
            }
            
            internal DOCGIADataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn MSDGColumn {
                get {
                    return this.columnMSDG;
                }
            }
            
            internal DataColumn TENDGColumn {
                get {
                    return this.columnTENDG;
                }
            }
            
            internal DataColumn DIACHIColumn {
                get {
                    return this.columnDIACHI;
                }
            }
            
            internal DataColumn NGAYSINHColumn {
                get {
                    return this.columnNGAYSINH;
                }
            }
            
            internal DataColumn EMAILColumn {
                get {
                    return this.columnEMAIL;
                }
            }
            
            internal DataColumn GIOITINHColumn {
                get {
                    return this.columnGIOITINH;
                }
            }
            
            internal DataColumn THONGTINKHACColumn {
                get {
                    return this.columnTHONGTINKHAC;
                }
            }
            
            internal DataColumn HINHANHDGColumn {
                get {
                    return this.columnHINHANHDG;
                }
            }
            
            public DOCGIARow this[int index] {
                get {
                    return ((DOCGIARow)(this.Rows[index]));
                }
            }
            
            public event DOCGIARowChangeEventHandler DOCGIARowChanged;
            
            public event DOCGIARowChangeEventHandler DOCGIARowChanging;
            
            public event DOCGIARowChangeEventHandler DOCGIARowDeleted;
            
            public event DOCGIARowChangeEventHandler DOCGIARowDeleting;
            
            public void AddDOCGIARow(DOCGIARow row) {
                this.Rows.Add(row);
            }
            
            public DOCGIARow AddDOCGIARow(string MSDG, string TENDG, string DIACHI, System.DateTime NGAYSINH, string EMAIL, string GIOITINH, string THONGTINKHAC, string HINHANHDG) {
                DOCGIARow rowDOCGIARow = ((DOCGIARow)(this.NewRow()));
                rowDOCGIARow.ItemArray = new object[] {
                        MSDG,
                        TENDG,
                        DIACHI,
                        NGAYSINH,
                        EMAIL,
                        GIOITINH,
                        THONGTINKHAC,
                        HINHANHDG};
                this.Rows.Add(rowDOCGIARow);
                return rowDOCGIARow;
            }
            
            public DOCGIARow FindByMSDG(string MSDG) {
                return ((DOCGIARow)(this.Rows.Find(new object[] {
                            MSDG})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                DOCGIADataTable cln = ((DOCGIADataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new DOCGIADataTable();
            }
            
            internal void InitVars() {
                this.columnMSDG = this.Columns["MSDG"];
                this.columnTENDG = this.Columns["TENDG"];
                this.columnDIACHI = this.Columns["DIACHI"];
                this.columnNGAYSINH = this.Columns["NGAYSINH"];
                this.columnEMAIL = this.Columns["EMAIL"];
                this.columnGIOITINH = this.Columns["GIOITINH"];
                this.columnTHONGTINKHAC = this.Columns["THONGTINKHAC"];
                this.columnHINHANHDG = this.Columns["HINHANHDG"];
            }
            
            private void InitClass() {
                this.columnMSDG = new DataColumn("MSDG", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMSDG);
                this.columnTENDG = new DataColumn("TENDG", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTENDG);
                this.columnDIACHI = new DataColumn("DIACHI", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDIACHI);
                this.columnNGAYSINH = new DataColumn("NGAYSINH", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNGAYSINH);
                this.columnEMAIL = new DataColumn("EMAIL", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEMAIL);
                this.columnGIOITINH = new DataColumn("GIOITINH", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnGIOITINH);
                this.columnTHONGTINKHAC = new DataColumn("THONGTINKHAC", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTHONGTINKHAC);
                this.columnHINHANHDG = new DataColumn("HINHANHDG", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHINHANHDG);
                this.Constraints.Add(new UniqueConstraint("dtDocGiaKey1", new DataColumn[] {
                                this.columnMSDG}, true));
                this.columnMSDG.AllowDBNull = false;
                this.columnMSDG.Unique = true;
                this.columnTENDG.AllowDBNull = false;
            }
            
            public DOCGIARow NewDOCGIARow() {
                return ((DOCGIARow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new DOCGIARow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(DOCGIARow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.DOCGIARowChanged != null)) {
                    this.DOCGIARowChanged(this, new DOCGIARowChangeEvent(((DOCGIARow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.DOCGIARowChanging != null)) {
                    this.DOCGIARowChanging(this, new DOCGIARowChangeEvent(((DOCGIARow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.DOCGIARowDeleted != null)) {
                    this.DOCGIARowDeleted(this, new DOCGIARowChangeEvent(((DOCGIARow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.DOCGIARowDeleting != null)) {
                    this.DOCGIARowDeleting(this, new DOCGIARowChangeEvent(((DOCGIARow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveDOCGIARow(DOCGIARow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DOCGIARow : DataRow {
            
            private DOCGIADataTable tableDOCGIA;
            
            internal DOCGIARow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableDOCGIA = ((DOCGIADataTable)(this.Table));
            }
            
            public string MSDG {
                get {
                    return ((string)(this[this.tableDOCGIA.MSDGColumn]));
                }
                set {
                    this[this.tableDOCGIA.MSDGColumn] = value;
                }
            }
            
            public string TENDG {
                get {
                    return ((string)(this[this.tableDOCGIA.TENDGColumn]));
                }
                set {
                    this[this.tableDOCGIA.TENDGColumn] = value;
                }
            }
            
            public string DIACHI {
                get {
                    try {
                        return ((string)(this[this.tableDOCGIA.DIACHIColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDOCGIA.DIACHIColumn] = value;
                }
            }
            
            public System.DateTime NGAYSINH {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableDOCGIA.NGAYSINHColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDOCGIA.NGAYSINHColumn] = value;
                }
            }
            
            public string EMAIL {
                get {
                    try {
                        return ((string)(this[this.tableDOCGIA.EMAILColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDOCGIA.EMAILColumn] = value;
                }
            }
            
            public string GIOITINH {
                get {
                    try {
                        return ((string)(this[this.tableDOCGIA.GIOITINHColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDOCGIA.GIOITINHColumn] = value;
                }
            }
            
            public string THONGTINKHAC {
                get {
                    try {
                        return ((string)(this[this.tableDOCGIA.THONGTINKHACColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDOCGIA.THONGTINKHACColumn] = value;
                }
            }
            
            public string HINHANHDG {
                get {
                    try {
                        return ((string)(this[this.tableDOCGIA.HINHANHDGColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDOCGIA.HINHANHDGColumn] = value;
                }
            }
            
            public bool IsDIACHINull() {
                return this.IsNull(this.tableDOCGIA.DIACHIColumn);
            }
            
            public void SetDIACHINull() {
                this[this.tableDOCGIA.DIACHIColumn] = System.Convert.DBNull;
            }
            
            public bool IsNGAYSINHNull() {
                return this.IsNull(this.tableDOCGIA.NGAYSINHColumn);
            }
            
            public void SetNGAYSINHNull() {
                this[this.tableDOCGIA.NGAYSINHColumn] = System.Convert.DBNull;
            }
            
            public bool IsEMAILNull() {
                return this.IsNull(this.tableDOCGIA.EMAILColumn);
            }
            
            public void SetEMAILNull() {
                this[this.tableDOCGIA.EMAILColumn] = System.Convert.DBNull;
            }
            
            public bool IsGIOITINHNull() {
                return this.IsNull(this.tableDOCGIA.GIOITINHColumn);
            }
            
            public void SetGIOITINHNull() {
                this[this.tableDOCGIA.GIOITINHColumn] = System.Convert.DBNull;
            }
            
            public bool IsTHONGTINKHACNull() {
                return this.IsNull(this.tableDOCGIA.THONGTINKHACColumn);
            }
            
            public void SetTHONGTINKHACNull() {
                this[this.tableDOCGIA.THONGTINKHACColumn] = System.Convert.DBNull;
            }
            
            public bool IsHINHANHDGNull() {
                return this.IsNull(this.tableDOCGIA.HINHANHDGColumn);
            }
            
            public void SetHINHANHDGNull() {
                this[this.tableDOCGIA.HINHANHDGColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DOCGIARowChangeEvent : EventArgs {
            
            private DOCGIARow eventRow;
            
            private DataRowAction eventAction;
            
            public DOCGIARowChangeEvent(DOCGIARow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public DOCGIARow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
