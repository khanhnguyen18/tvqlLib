﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file GoodsGrp.cs instead.
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
	/// An object representation of the 'tblGoodsGrp' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class GoodsGrpBase : EntityBase, IGoodsGrp, IEntityId<GoodsGrpKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private GoodsGrpEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private GoodsGrpEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private GoodsGrpEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<GoodsGrp> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event GoodsGrpEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event GoodsGrpEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="GoodsGrpBase"/> instance.
		///</summary>
		public GoodsGrpBase()
		{
			this.entityData = new GoodsGrpEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="GoodsGrpBase"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_description"></param>
		///<param name="_status"></param>
		public GoodsGrpBase(System.String _id, System.String _description, System.Boolean _status)
		{
			this.entityData = new GoodsGrpEntityData();
			this.backupData = null;

			this.Id = _id;
			this.Description = _description;
			this.Status = _status;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="GoodsGrp"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_description"></param>
		///<param name="_status"></param>
		public static GoodsGrp CreateGoodsGrp(System.String _id, System.String _description, System.Boolean _status)
		{
			GoodsGrp newGoodsGrp = new GoodsGrp();
			newGoodsGrp.Id = _id;
			newGoodsGrp.Description = _description;
			newGoodsGrp.Status = _status;
			return newGoodsGrp;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the Id property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 4)]
		public virtual System.String Id
		{
			get
			{
				return this.entityData.Id; 
			}
			
			set
			{
				if (this.entityData.Id == value)
					return;
				
                OnPropertyChanging("Id");                    
				OnColumnChanging(GoodsGrpColumn.Id, this.entityData.Id);
				this.entityData.Id = value;
				this.EntityId.Id = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(GoodsGrpColumn.Id, this.entityData.Id);
				OnPropertyChanged("Id");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the Id property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the Id property.</remarks>
		/// <value>This type is nvarchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalId
		{
			get { return this.entityData.OriginalId; }
			set { this.entityData.OriginalId = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the Description property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 100)]
		public virtual System.String Description
		{
			get
			{
				return this.entityData.Description; 
			}
			
			set
			{
				if (this.entityData.Description == value)
					return;
				
                OnPropertyChanging("Description");                    
				OnColumnChanging(GoodsGrpColumn.Description, this.entityData.Description);
				this.entityData.Description = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(GoodsGrpColumn.Description, this.entityData.Description);
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the Status property. 
		///		
		/// </summary>
		/// <value>This type is bit.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false)]
		public virtual System.Boolean Status
		{
			get
			{
				return this.entityData.Status; 
			}
			
			set
			{
				if (this.entityData.Status == value)
					return;
				
                OnPropertyChanging("Status");                    
				OnColumnChanging(GoodsGrpColumn.Status, this.entityData.Status);
				this.entityData.Status = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(GoodsGrpColumn.Status, this.entityData.Status);
				OnPropertyChanged("Status");
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
				new ValidationRuleArgs("Id", "Id"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("Id", "Id", 4));
			ValidationRules.AddRule( CommonRules.NotNull,
				new ValidationRuleArgs("Description", "Description"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("Description", "Description", 100));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "tblGoodsGrp"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"Id", "Description", "Status"};
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
	            this.backupData = this.entityData.Clone() as GoodsGrpEntityData;
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
						this.parentCollection.Remove( (GoodsGrp) this ) ;
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
	            this.parentCollection = value as TList<GoodsGrp>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as GoodsGrp);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed GoodsGrp Entity 
		///</summary>
		protected virtual GoodsGrp Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			GoodsGrp copy = new GoodsGrp();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.Id = this.Id;
					copy.OriginalId = this.OriginalId;
				copy.Description = this.Description;
				copy.Status = this.Status;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed GoodsGrp Entity 
		///</summary>
		public virtual GoodsGrp Copy()
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
		///  Returns a Typed GoodsGrp Entity which is a deep copy of the current entity.
		///</summary>
		public virtual GoodsGrp DeepCopy()
		{
			return EntityHelper.Clone<GoodsGrp>(this as GoodsGrp);	
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
				this.entityData = this._originalData.Clone() as GoodsGrpEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new GoodsGrpEntityData();
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
			this._originalData = this.entityData.Clone() as GoodsGrpEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(GoodsGrpColumn column)
		{
			switch(column)
			{
					case GoodsGrpColumn.Id:
					return entityData.Id != _originalData.Id;
					case GoodsGrpColumn.Description:
					return entityData.Description != _originalData.Description;
					case GoodsGrpColumn.Status:
					return entityData.Status != _originalData.Status;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< GoodsGrpColumn >(columnName));
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
			result = result || entityData.Id != _originalData.Id;
			result = result || entityData.Description != _originalData.Description;
			result = result || entityData.Status != _originalData.Status;
			return result;
		}	
		
		///<summary>
		///  Returns a GoodsGrp Entity with the original data.
		///</summary>
		public GoodsGrp GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateGoodsGrp(
				_originalData.Id,
				_originalData.Description,
				_originalData.Status
				);
				
			return (GoodsGrp)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="GoodsGrpBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is GoodsGrpBase)
				return ValueEquals(this, (GoodsGrpBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="GoodsGrpBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.Id.GetHashCode() ^ 
					this.Description.GetHashCode() ^ 
					this.Status.GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="GoodsGrpBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(GoodsGrpBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="GoodsGrpBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="GoodsGrpBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="GoodsGrpBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(GoodsGrpBase Object1, GoodsGrpBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.Id != Object2.Id)
				equal = false;
			if (Object1.Description != Object2.Description)
				equal = false;
			if (Object1.Status != Object2.Status)
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((GoodsGrpBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static GoodsGrpComparer GetComparer()
        {
            return new GoodsGrpComparer();
        }
        */

        // Comparer delegates back to GoodsGrp
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
        public int CompareTo(GoodsGrp rhs, GoodsGrpColumn which)
        {
            switch (which)
            {
            	
            	
            	case GoodsGrpColumn.Id:
            		return this.Id.CompareTo(rhs.Id);
            		
            		                 
            	
            	
            	case GoodsGrpColumn.Description:
            		return this.Description.CompareTo(rhs.Description);
            		
            		                 
            	
            	
            	case GoodsGrpColumn.Status:
            		return this.Status.CompareTo(rhs.Status);
            		
            		                 
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
				
		#region IEntityKey<GoodsGrpKey> Members
		
		// member variable for the EntityId property
		private GoodsGrpKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual GoodsGrpKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new GoodsGrpKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("GoodsGrp")
					.Append("|").Append( this.Id.ToString()).ToString();
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
				"{4}{3}- Id: {0}{3}- Description: {1}{3}- Status: {2}{3}{5}", 
				this.Id,
				this.Description,
				this.Status,
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'tblGoodsGrp' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class GoodsGrpEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// Id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblGoodsGrp"</remarks>
		public System.String Id;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalId;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// Description : 
		/// </summary>
		public System.String Description = string.Empty;
		
		/// <summary>
		/// Status : 
		/// </summary>
		public System.Boolean Status = true;
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
			GoodsGrpEntityData _tmp = new GoodsGrpEntityData();
						
			_tmp.Id = this.Id;
			_tmp.OriginalId = this.OriginalId;
			
			_tmp.Description = this.Description;
			_tmp.Status = this.Status;
			
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
				
			GoodsGrpEntityData _tmp = new GoodsGrpEntityData();
						
			_tmp.Id = this.Id;
			_tmp.OriginalId = this.OriginalId;
			
			_tmp.Description = this.Description;
			_tmp.Status = this.Status;
			
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
		/// <param name="column">The <see cref="GoodsGrpColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(GoodsGrpColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="GoodsGrpColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(GoodsGrpColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="GoodsGrpColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(GoodsGrpColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				GoodsGrpEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new GoodsGrpEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="GoodsGrpColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(GoodsGrpColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				GoodsGrpEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new GoodsGrpEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region GoodsGrpEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="GoodsGrp"/> object.
	/// </remarks>
	public class GoodsGrpEventArgs : System.EventArgs
	{
		private GoodsGrpColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the GoodsGrpEventArgs class.
		///</summary>
		public GoodsGrpEventArgs(GoodsGrpColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the GoodsGrpEventArgs class.
		///</summary>
		public GoodsGrpEventArgs(GoodsGrpColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The GoodsGrpColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="GoodsGrpColumn" />
		public GoodsGrpColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all GoodsGrp related events.
	///</summary>
	public delegate void GoodsGrpEventHandler(object sender, GoodsGrpEventArgs e);
	
	#region GoodsGrpComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class GoodsGrpComparer : System.Collections.Generic.IComparer<GoodsGrp>
	{
		GoodsGrpColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:GoodsGrpComparer"/> class.
        /// </summary>
		public GoodsGrpComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:GoodsGrpComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public GoodsGrpComparer(GoodsGrpColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="GoodsGrp"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="GoodsGrp"/> to compare.</param>
        /// <param name="b">The second <c>GoodsGrp</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(GoodsGrp a, GoodsGrp b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(GoodsGrp entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(GoodsGrp a, GoodsGrp b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public GoodsGrpColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region GoodsGrpKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="GoodsGrp"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class GoodsGrpKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the GoodsGrpKey class.
		/// </summary>
		public GoodsGrpKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the GoodsGrpKey class.
		/// </summary>
		public GoodsGrpKey(GoodsGrpBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.Id = entity.Id;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the GoodsGrpKey class.
		/// </summary>
		public GoodsGrpKey(System.String _id)
		{
			#region Init Properties

			this.Id = _id;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private GoodsGrpBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public GoodsGrpBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the Id property
		private System.String _id;
		
		/// <summary>
		/// Gets or sets the Id property.
		/// </summary>
		public System.String Id
		{
			get { return _id; }
			set
			{
				if ( this.Entity != null )
					this.Entity.Id = value;
				
				_id = value;
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
				Id = ( values["Id"] != null ) ? (System.String) EntityUtil.ChangeType(values["Id"], typeof(System.String)) : string.Empty;
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

			values.Add("Id", Id);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("Id: {0}{1}",
								Id,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region GoodsGrpColumn Enum
	
	/// <summary>
	/// Enumerate the GoodsGrp columns.
	/// </summary>
	[Serializable]
	public enum GoodsGrpColumn : int
	{
		/// <summary>
		/// Id : 
		/// </summary>
		[EnumTextValue("Id")]
		[ColumnEnum("Id", typeof(System.String), System.Data.DbType.String, true, false, false, 4)]
		Id = 1,
		/// <summary>
		/// Description : 
		/// </summary>
		[EnumTextValue("Description")]
		[ColumnEnum("Description", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		Description = 2,
		/// <summary>
		/// Status : 
		/// </summary>
		[EnumTextValue("Status")]
		[ColumnEnum("Status", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, false)]
		Status = 3
	}//End enum

	#endregion GoodsGrpColumn Enum

} // end namespace
