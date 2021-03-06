﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file StoreTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using LibraryManagement.Domain;
using LibraryManagement.Dao;
using LibraryManagement.Dao.Bases;

#endregion

namespace LibraryManagement.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="Store"/> objects (entity, collection and repository).
    /// </summary>
   public partial class StoreTest
    {
    	// the Store instance used to test the repository.
		protected Store mock;
		
		// the TList<Store> instance used to test the repository.
		protected TList<Store> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the Store Entity with the {0} --", LibraryManagement.Dao.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock Store entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.StoreProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.StoreProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all Store objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.StoreProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.StoreProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.StoreProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all Store children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.StoreProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.StoreProvider.DeepLoading += new EntityProviderBaseCore<Store, StoreKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.StoreProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("Store instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.StoreProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock Store entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Store mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.StoreProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.StoreProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.StoreProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock Store entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (Store)CreateMockInstance(tm);
				DataRepository.StoreProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.StoreProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.StoreProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock Store entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Store.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock Store entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Store.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<Store>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a Store collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_StoreCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<Store> mockCollection = new TList<Store>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<Store> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a Store collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_StoreCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<Store>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<Store> mockCollection = (TList<Store>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<Store> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Store entity = CreateMockInstance(tm);
				bool result = DataRepository.StoreProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Store entity = CreateMockInstance(tm);
				bool result = DataRepository.StoreProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				Store t0 = DataRepository.StoreProvider.GetById(tm, entity.Id);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				Store entity = mock.Copy() as Store;
				entity = (Store)mock.Clone();
				Assert.IsTrue(Store.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				Store mock = CreateMockInstance(tm);
				bool result = DataRepository.StoreProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				StoreQuery query = new StoreQuery();
			
				query.AppendEquals(StoreColumn.Id, mock.Id.ToString());
				if(mock.Type != null)
					query.AppendEquals(StoreColumn.Type, mock.Type.ToString());
				if(mock.Name != null)
					query.AppendEquals(StoreColumn.Name, mock.Name.ToString());
				if(mock.Fullname != null)
					query.AppendEquals(StoreColumn.Fullname, mock.Fullname.ToString());
				if(mock.Address != null)
					query.AppendEquals(StoreColumn.Address, mock.Address.ToString());
				if(mock.Phone != null)
					query.AppendEquals(StoreColumn.Phone, mock.Phone.ToString());
				if(mock.Fax != null)
					query.AppendEquals(StoreColumn.Fax, mock.Fax.ToString());
				if(mock.Bankname != null)
					query.AppendEquals(StoreColumn.Bankname, mock.Bankname.ToString());
				if(mock.BankBr != null)
					query.AppendEquals(StoreColumn.BankBr, mock.BankBr.ToString());
				if(mock.Accnum != null)
					query.AppendEquals(StoreColumn.Accnum, mock.Accnum.ToString());
				if(mock.Vatnum != null)
					query.AppendEquals(StoreColumn.Vatnum, mock.Vatnum.ToString());
				if(mock.Contactps != null)
					query.AppendEquals(StoreColumn.Contactps, mock.Contactps.ToString());
				if(mock.Remark != null)
					query.AppendEquals(StoreColumn.Remark, mock.Remark.ToString());
				if(mock.OpenDate != null)
					query.AppendEquals(StoreColumn.OpenDate, mock.OpenDate.ToString());
				query.AppendEquals(StoreColumn.Status, mock.Status.ToString());
				
				TList<Store> results = DataRepository.StoreProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed Store Entity with mock values.
		///</summary>
		static public Store CreateMockInstance_Generated(TransactionManager tm)
		{		
			Store mock = new Store();
						
			mock.Id = TestUtility.Instance.RandomString(5, false);;
			mock.Type = TestUtility.Instance.RandomString(2, false);;
			mock.Name = TestUtility.Instance.RandomString(49, false);;
			mock.Fullname = TestUtility.Instance.RandomString(99, false);;
			mock.Address = TestUtility.Instance.RandomString(249, false);;
			mock.Phone = TestUtility.Instance.RandomString(49, false);;
			mock.Fax = TestUtility.Instance.RandomString(24, false);;
			mock.Bankname = TestUtility.Instance.RandomString(74, false);;
			mock.BankBr = TestUtility.Instance.RandomString(74, false);;
			mock.Accnum = TestUtility.Instance.RandomString(24, false);;
			mock.Vatnum = TestUtility.Instance.RandomString(24, false);;
			mock.Contactps = TestUtility.Instance.RandomString(24, false);;
			mock.Remark = TestUtility.Instance.RandomString(249, false);;
			mock.OpenDate = TestUtility.Instance.RandomDateTime();
			mock.Status = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<Store> tempMockCollection = new TList<Store>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (Store)mock;
		}
		
		
		///<summary>
		///  Update the Typed Store Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, Store mock)
		{
			mock.Type = TestUtility.Instance.RandomString(2, false);;
			mock.Name = TestUtility.Instance.RandomString(49, false);;
			mock.Fullname = TestUtility.Instance.RandomString(99, false);;
			mock.Address = TestUtility.Instance.RandomString(249, false);;
			mock.Phone = TestUtility.Instance.RandomString(49, false);;
			mock.Fax = TestUtility.Instance.RandomString(24, false);;
			mock.Bankname = TestUtility.Instance.RandomString(74, false);;
			mock.BankBr = TestUtility.Instance.RandomString(74, false);;
			mock.Accnum = TestUtility.Instance.RandomString(24, false);;
			mock.Vatnum = TestUtility.Instance.RandomString(24, false);;
			mock.Contactps = TestUtility.Instance.RandomString(24, false);;
			mock.Remark = TestUtility.Instance.RandomString(249, false);;
			mock.OpenDate = TestUtility.Instance.RandomDateTime();
			mock.Status = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
