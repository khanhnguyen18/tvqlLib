﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file Transnum.cs instead.
*/

#region using directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using LibraryManagement.Domain.Validation;
#endregion

namespace LibraryManagement.Domain
{
	///<summary>
	/// An object representation of the 'tblTransnum' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class TransnumBase : EntityBase, ITransnum, IEntityId<TransnumKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private TransnumEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private TransnumEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private TransnumEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<Transnum> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event TransnumEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event TransnumEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="TransnumBase"/> instance.
		///</summary>
		public TransnumBase()
		{
			this.entityData = new TransnumEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="TransnumBase"/> instance.
		///</summary>
		///<param name="_transType"></param>
		///<param name="_lastNum"></param>
		///<param name="_lastDate"></param>
		public TransnumBase(System.String _transType, System.Decimal _lastNum, System.DateTime _lastDate)
		{
			this.entityData = new TransnumEntityData();
			this.backupData = null;

			this.TransType = _transType;
			this.LastNum = _lastNum;
			this.LastDate = _lastDate;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="Transnum"/> instance.
		///</summary>
		///<param name="_transType"></param>
		///<param name="_lastNum"></param>
		///<param name="_lastDate"></param>
		public static Transnum CreateTransnum(System.String _transType, System.Decimal _lastNum, System.DateTime _lastDate)
		{
			Transnum newTransnum = new Transnum();
			newTransnum.TransType = _transType;
			newTransnum.LastNum = _lastNum;
			newTransnum.LastDate = _lastDate;
			return newTransnum;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the TransType property. 
		///		
		/// </summary>
		/// <value>This type is char.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 4)]
		public virtual System.String TransType
		{
			get
			{
				return this.entityData.TransType; 
			}
			
			set
			{
				if (this.entityData.TransType == value)
					return;
				
                OnPropertyChanging("TransType");                    
				OnColumnChanging(TransnumColumn.TransType, this.entityData.TransType);
				this.entityData.TransType = value;
				this.EntityId.TransType = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TransnumColumn.TransType, this.entityData.TransType);
				OnPropertyChanged("TransType");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the trans_type property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the trans_type property.</remarks>
		/// <value>This type is char</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalTransType
		{
			get { return this.entityData.OriginalTransType; }
			set { this.entityData.OriginalTransType = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the LastNum property. 
		///		
		/// </summary>
		/// <value>This type is decimal.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false)]
		public virtual System.Decimal LastNum
		{
			get
			{
				return this.entityData.LastNum; 
			}
			
			set
			{
				if (this.entityData.LastNum == value)
					return;
				
                OnPropertyChanging("LastNum");                    
				OnColumnChanging(TransnumColumn.LastNum, this.entityData.LastNum);
				this.entityData.LastNum = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TransnumColumn.LastNum, this.entityData.LastNum);
				OnPropertyChanged("LastNum");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the LastDate property. 
		///		
		/// </summary>
		/// <value>This type is datetime.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false)]
		public virtual System.DateTime LastDate
		{
			get
			{
				return this.entityData.LastDate; 
			}
			
			set
			{
				if (this.entityData.LastDate == value)
					return;
				
                OnPropertyChanging("LastDate");                    
				OnColumnChanging(TransnumColumn.LastDate, this.entityData.LastDate);
				this.entityData.LastDate = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TransnumColumn.LastDate, this.entityData.LastDate);
				OnPropertyChanged("LastDate");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
		#endregion Children Collections
		
		#endregion
		#region Validation
		
		/// <summary>
		/// Assigns validation rules to this object based on model definition.
		/// </summary>
		/// <remarks>This method overrides the base class to add schema related validation.</remarks>
		protected override void AddValidationRules()
		{
			//Validation rules based on database schema.
			ValidationRules.AddRule( CommonRules.NotNull,
				new ValidationRuleArgs("TransType", "Trans Type"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("TransType", "Trans Type", 4));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "tblTransnum"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"trans_type", "last_num", "last_date"};
			}
		}
		#endregion 
		
		#region IEditableObject
		
		#region  CancelAddNew Event
		/// <summary>
        /// The delegate for the CancelAddNew event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public delegate void CancelAddNewEventHandler(object sender, EventArgs e);
    
    	/// <summary>
		/// The CancelAddNew event.
		/// </summary>
		[field:NonSerialized]
		public event CancelAddNewEventHandler CancelAddNew ;

		/// <summary>
        /// Called when [cancel add new].
        /// </summary>
        public void OnCancelAddNew()
        {    
			if (!SuppressEntityEvents)
			{
	            CancelAddNewEventHandler handler = CancelAddNew ;
            	if (handler != null)
	            {    
    	            handler(this, EventArgs.Empty) ;
        	    }
	        }
        }
		#endregion 
		
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		void IEditableObject.BeginEdit() 
	    {
	        //Console.WriteLine("Start BeginEdit");
	        if (!inTxn) 
	        {
	            this.backupData = this.entityData.Clone() as TransnumEntityData;
	            inTxn = true;
	            //Console.WriteLine("BeginEdit");
	        }
	        //Console.WriteLine("End BeginEdit");
	    }
	
		/// <summary>
		/// Discards changes since the last <c>BeginEdit</c> call.
		/// </summary>
	    void IEditableObject.CancelEdit() 
	    {
	        //Console.WriteLine("Start CancelEdit");
	        if (this.inTxn) 
	        {
	            this.entityData = this.backupData;
	            this.backupData = null;
				this.inTxn = false;

				if (this.bindingIsNew)
	        	//if (this.EntityState == EntityState.Added)
	        	{
					if (this.parentCollection != null)
						this.parentCollection.Remove( (Transnum) this ) ;
				}	            
	        }
	        //Console.WriteLine("End CancelEdit");
	    }
	
		/// <summary>
		/// Pushes changes since the last <c>BeginEdit</c> or <c>IBindingList.AddNew</c> call into the underlying object.
		/// </summary>
	    void IEditableObject.EndEdit() 
	    {
	        //Console.WriteLine("Start EndEdit" + this.custData.id + this.custData.lastName);
	        if (this.inTxn) 
	        {
	            this.backupData = null;
				if (this.IsDirty) 
				{
					if (this.bindingIsNew) {
						this.EntityState = EntityState.Added;
						this.bindingIsNew = false ;
					}
					else
						if (this.EntityState == EntityState.Unchanged) 
							this.EntityState = EntityState.Changed ;
				}

				this.bindingIsNew = false ;
	            this.inTxn = false;	            
	        }
	        //Console.WriteLine("End EndEdit");
	    }
	    
	    /// <summary>
        /// Gets or sets the parent collection of this current entity, if available.
        /// </summary>
        /// <value>The parent collection.</value>
	    [XmlIgnore]
		[Browsable(false)]
	    public override object ParentCollection
	    {
	        get 
	        {
	            return this.parentCollection;
	        }
	        set 
	        {
	            this.parentCollection = value as TList<Transnum>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as Transnum);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed Transnum Entity 
		///</summary>
		protected virtual Transnum Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			Transnum copy = new Transnum();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.TransType = this.TransType;
					copy.OriginalTransType = this.OriginalTransType;
				copy.LastNum = this.LastNum;
				copy.LastDate = this.LastDate;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed Transnum Entity 
		///</summary>
		public virtual Transnum Copy()
		{
			return this.Copy(null);	
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone()
		{
			return this.Copy(null);
		}
		
		///<summary>
		/// ICloneableEx.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone(IDictionary existingCopies)
		{
			return this.Copy(existingCopies);
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x == null)
				return null;
				
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x, IDictionary existingCopies)
		{
			if (x == null)
				return null;
			
			if (x is ICloneableEx)
			{
				// Return a deep copy of the object
				return ((ICloneableEx)x).Clone(existingCopies);
			}
			else if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable or IClonableEx Interface.");
		}
		
		
		///<summary>
		///  Returns a Typed Transnum Entity which is a deep copy of the current entity.
		///</summary>
		public virtual Transnum DeepCopy()
		{
			return EntityHelper.Clone<Transnum>(this as Transnum);	
		}
		#endregion
		
		#region Methods	
			
		///<summary>
		/// Revert all changes and restore original values.
		///</summary>
		public override void CancelChanges()
		{
			IEditableObject obj = (IEditableObject) this;
			obj.CancelEdit();

			this.entityData = null;
			if (this._originalData != null)
			{
				this.entityData = this._originalData.Clone() as TransnumEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new TransnumEntityData();
			}
		}	
		
		/// <summary>
		/// Accepts the changes made to this object.
		/// </summary>
		/// <remarks>
		/// After calling this method, properties: IsDirty, IsNew are false. IsDeleted flag remains unchanged as it is handled by the parent List.
		/// </remarks>
		public override void AcceptChanges()
		{
			base.AcceptChanges();

			// we keep of the original version of the data
			this._originalData = null;
			this._originalData = this.entityData.Clone() as TransnumEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(TransnumColumn column)
		{
			switch(column)
			{
					case TransnumColumn.TransType:
					return entityData.TransType != _originalData.TransType;
					case TransnumColumn.LastNum:
					return entityData.LastNum != _originalData.LastNum;
					case TransnumColumn.LastDate:
					return entityData.LastDate != _originalData.LastDate;
			
				default:
					return false;
			}
		}
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="columnName">The column name.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public override bool IsPropertyChanged(string columnName)
		{
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< TransnumColumn >(columnName));
		}
		
		/// <summary>
		/// Determines whether the data has changed from original.
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if data has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool HasDataChanged()
		{
			bool result = false;
			result = result || entityData.TransType != _originalData.TransType;
			result = result || entityData.LastNum != _originalData.LastNum;
			result = result || entityData.LastDate != _originalData.LastDate;
			return result;
		}	
		
		///<summary>
		///  Returns a Transnum Entity with the original data.
		///</summary>
		public Transnum GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateTransnum(
				_originalData.TransType,
				_originalData.LastNum,
				_originalData.LastDate
				);
				
			return (Transnum)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="TransnumBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is TransnumBase)
				return ValueEquals(this, (TransnumBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="TransnumBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.TransType.GetHashCode() ^ 
					this.LastNum.GetHashCode() ^ 
					this.LastDate.GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="TransnumBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(TransnumBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="TransnumBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="TransnumBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="TransnumBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(TransnumBase Object1, TransnumBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.TransType != Object2.TransType)
				equal = false;
			if (Object1.LastNum != Object2.LastNum)
				equal = false;
			if (Object1.LastDate != Object2.LastDate)
				equal = false;
					
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((TransnumBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static TransnumComparer GetComparer()
        {
            return new TransnumComparer();
        }
        */

        // Comparer delegates back to Transnum
        // Employee uses the integer's default
        // CompareTo method
        /*
        public int CompareTo(Item rhs)
        {
            return this.Id.CompareTo(rhs.Id);
        }
        */

/*
        // Special implementation to be called by custom comparer
        public int CompareTo(Transnum rhs, TransnumColumn which)
        {
            switch (which)
            {
            	
            	
            	case TransnumColumn.TransType:
            		return this.TransType.CompareTo(rhs.TransType);
            		
            		                 
            	
            	
            	case TransnumColumn.LastNum:
            		return this.LastNum.CompareTo(rhs.LastNum);
            		
            		                 
            	
            	
            	case TransnumColumn.LastDate:
            		return this.LastDate.CompareTo(rhs.LastDate);
            		
            		                 
            }
            return 0;
        }
        */
	
		#endregion
		
		#region IComponent Members
		
		private ISite _site = null;

		/// <summary>
		/// Gets or Sets the site where this data is located.
		/// </summary>
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public ISite Site
		{
			get{ return this._site; }
			set{ this._site = value; }
		}

		#endregion

		#region IDisposable Members
		
		/// <summary>
		/// Notify those that care when we dispose.
		/// </summary>
		[field:NonSerialized]
		public event System.EventHandler Disposed;

		/// <summary>
		/// Clean up. Nothing here though.
		/// </summary>
		public virtual void Dispose()
		{
			this.parentCollection = null;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Clean up.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				EventHandler handler = Disposed;
				if (handler != null)
					handler(this, EventArgs.Empty);
			}
		}
		
		#endregion
				
		#region IEntityKey<TransnumKey> Members
		
		// member variable for the EntityId property
		private TransnumKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual TransnumKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new TransnumKey(this);
				}

				return _entityId;
			}
			set
			{
				if ( value != null )
				{
					value.Entity = this;
				}
				
				_entityId = value;
			}
		}
		
		#endregion
		
		#region EntityState
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false) , XmlIgnoreAttribute()]
		public override EntityState EntityState 
		{ 
			get{ return entityData.EntityState;	 } 
			set{ entityData.EntityState = value; } 
		}
		#endregion 
		
		#region EntityTrackingKey
		///<summary>
		/// Provides the tracking key for the <see cref="EntityLocator"/>
		///</summary>
		[XmlIgnore]
		public override string EntityTrackingKey
		{
			get
			{
				if(entityTrackingKey == null)
					entityTrackingKey = new System.Text.StringBuilder("Transnum")
					.Append("|").Append( this.TransType.ToString()).ToString();
				return entityTrackingKey;
			}
			set
		    {
		        if (value != null)
                    entityTrackingKey = value;
		    }
		}
		#endregion 
		
		#region ToString Method
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- TransType: {0}{3}- LastNum: {1}{3}- LastDate: {2}{3}{5}", 
				this.TransType,
				this.LastNum,
				this.LastDate,
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'tblTransnum' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class TransnumEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// trans_type : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblTransnum"</remarks>
		public System.String TransType;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalTransType;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// last_num : 
		/// </summary>
		public System.Decimal LastNum = 0.0m;
		
		/// <summary>
		/// last_date : 
		/// </summary>
		public System.DateTime LastDate = DateTime.MinValue;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
        
		#endregion Variable Declarations

		#region Data Properties

		#endregion Data Properties
		#region Clone Method

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public Object Clone()
		{
			TransnumEntityData _tmp = new TransnumEntityData();
						
			_tmp.TransType = this.TransType;
			_tmp.OriginalTransType = this.OriginalTransType;
			
			_tmp.LastNum = this.LastNum;
			_tmp.LastDate = this.LastDate;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone(IDictionary existingCopies)
		{
			if (existingCopies == null)
				existingCopies = new Hashtable();
				
			TransnumEntityData _tmp = new TransnumEntityData();
						
			_tmp.TransType = this.TransType;
			_tmp.OriginalTransType = this.OriginalTransType;
			
			_tmp.LastNum = this.LastNum;
			_tmp.LastDate = this.LastDate;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		#endregion Clone Method
		
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public EntityState	EntityState
		{
			get { return currentEntityState;  }
			set { currentEntityState = value; }
		}
	
	}//End struct

		#endregion
		
				
		
		#region Events trigger
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TransnumColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(TransnumColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TransnumColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(TransnumColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TransnumColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(TransnumColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				TransnumEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new TransnumEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TransnumColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(TransnumColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				TransnumEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new TransnumEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region TransnumEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="Transnum"/> object.
	/// </remarks>
	public class TransnumEventArgs : System.EventArgs
	{
		private TransnumColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the TransnumEventArgs class.
		///</summary>
		public TransnumEventArgs(TransnumColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the TransnumEventArgs class.
		///</summary>
		public TransnumEventArgs(TransnumColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The TransnumColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="TransnumColumn" />
		public TransnumColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all Transnum related events.
	///</summary>
	public delegate void TransnumEventHandler(object sender, TransnumEventArgs e);
	
	#region TransnumComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class TransnumComparer : System.Collections.Generic.IComparer<Transnum>
	{
		TransnumColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:TransnumComparer"/> class.
        /// </summary>
		public TransnumComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TransnumComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public TransnumComparer(TransnumColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="Transnum"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="Transnum"/> to compare.</param>
        /// <param name="b">The second <c>Transnum</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(Transnum a, Transnum b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(Transnum entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(Transnum a, Transnum b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public TransnumColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region TransnumKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="Transnum"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class TransnumKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the TransnumKey class.
		/// </summary>
		public TransnumKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the TransnumKey class.
		/// </summary>
		public TransnumKey(TransnumBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.TransType = entity.TransType;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the TransnumKey class.
		/// </summary>
		public TransnumKey(System.String _transType)
		{
			#region Init Properties

			this.TransType = _transType;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private TransnumBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public TransnumBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the TransType property
		private System.String _transType;
		
		/// <summary>
		/// Gets or sets the TransType property.
		/// </summary>
		public System.String TransType
		{
			get { return _transType; }
			set
			{
				if ( this.Entity != null )
					this.Entity.TransType = value;
				
				_transType = value;
			}
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Reads values from the supplied <see cref="IDictionary"/> object into
		/// properties of the current object.
		/// </summary>
		/// <param name="values">An <see cref="IDictionary"/> instance that contains
		/// the key/value pairs to be used as property values.</param>
		public override void Load(IDictionary values)
		{
			#region Init Properties

			if ( values != null )
			{
				TransType = ( values["TransType"] != null ) ? (System.String) EntityUtil.ChangeType(values["TransType"], typeof(System.String)) : string.Empty;
			}

			#endregion
		}

		/// <summary>
		/// Creates a new <see cref="IDictionary"/> object and populates it
		/// with the property values of the current object.
		/// </summary>
		/// <returns>A collection of name/value pairs.</returns>
		public override IDictionary ToDictionary()
		{
			IDictionary values = new Hashtable();

			#region Init Dictionary

			values.Add("TransType", TransType);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("TransType: {0}{1}",
								TransType,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region TransnumColumn Enum
	
	/// <summary>
	/// Enumerate the Transnum columns.
	/// </summary>
	[Serializable]
	public enum TransnumColumn : int
	{
		/// <summary>
		/// TransType : 
		/// </summary>
		[EnumTextValue("Trans Type")]
		[ColumnEnum("trans_type", typeof(System.String), System.Data.DbType.AnsiStringFixedLength, true, false, false, 4)]
		TransType = 1,
		/// <summary>
		/// LastNum : 
		/// </summary>
		[EnumTextValue("Last Num")]
		[ColumnEnum("last_num", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		LastNum = 2,
		/// <summary>
		/// LastDate : 
		/// </summary>
		[EnumTextValue("Last Date")]
		[ColumnEnum("last_date", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, false)]
		LastDate = 3
	}//End enum

	#endregion TransnumColumn Enum

} // end namespace
