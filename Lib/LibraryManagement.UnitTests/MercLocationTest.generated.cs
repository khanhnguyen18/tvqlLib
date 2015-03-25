﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file MercLocationTest.cs instead.
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
    /// Provides tests for the and <see cref="MercLocation"/> objects (entity, collection and repository).
    /// </summary>
   public partial class MercLocationTest
    {
    	// the MercLocation instance used to test the repository.
		protected MercLocation mock;
		
		// the TList<MercLocation> instance used to test the repository.
		protected TList<MercLocation> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the MercLocation Entity with the {0} --", LibraryManagement.Dao.DataRepository.Provider.Name);
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
		/// Inserts a mock MercLocation entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.MercLocationProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.MercLocationProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all MercLocation objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.MercLocationProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.MercLocationProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.MercLocationProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all MercLocation children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.MercLocationProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.MercLocationProvider.DeepLoading += new EntityProviderBaseCore<MercLocation, MercLocationKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.MercLocationProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("MercLocation instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.MercLocationProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock MercLocation entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MercLocation mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.MercLocationProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.MercLocationProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.MercLocationProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock MercLocation entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (MercLocation)CreateMockInstance(tm);
				DataRepository.MercLocationProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.MercLocationProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.MercLocationProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock MercLocation entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MercLocation.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock MercLocation entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MercLocation.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<MercLocation>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a MercLocation collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MercLocationCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<MercLocation> mockCollection = new TList<MercLocation>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<MercLocation> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a MercLocation collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MercLocationCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<MercLocation>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<MercLocation> mockCollection = (TList<MercLocation>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<MercLocation> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MercLocation entity = CreateMockInstance(tm);
				bool result = DataRepository.MercLocationProvider.Insert(tm, entity);
				
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
				MercLocation entity = CreateMockInstance(tm);
				bool result = DataRepository.MercLocationProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				MercLocation t0 = DataRepository.MercLocationProvider.GetByIdx(tm, entity.Idx);
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
				
				MercLocation entity = mock.Copy() as MercLocation;
				entity = (MercLocation)mock.Clone();
				Assert.IsTrue(MercLocation.ValueEquals(entity, mock), "Clone is not working");
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
				MercLocation mock = CreateMockInstance(tm);
				bool result = DataRepository.MercLocationProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				MercLocationQuery query = new MercLocationQuery();
			
				query.AppendEquals(MercLocationColumn.Idx, mock.Idx.ToString());
				query.AppendEquals(MercLocationColumn.StkId, mock.StkId.ToString());
				query.AppendEquals(MercLocationColumn.LocId, mock.LocId.ToString());
				query.AppendEquals(MercLocationColumn.GoodsId, mock.GoodsId.ToString());
				query.AppendEquals(MercLocationColumn.Check, mock.Check.ToString());
				
				TList<MercLocation> results = DataRepository.MercLocationProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed MercLocation Entity with mock values.
		///</summary>
		static public MercLocation CreateMockInstance_Generated(TransactionManager tm)
		{		
			MercLocation mock = new MercLocation();
						
			mock.StkId = TestUtility.Instance.RandomString(5, false);;
			mock.LocId = TestUtility.Instance.RandomString(4, false);;
			mock.GoodsId = TestUtility.Instance.RandomString(6, false);;
			mock.Check = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<MercLocation> tempMockCollection = new TList<MercLocation>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (MercLocation)mock;
		}
		
		
		///<summary>
		///  Update the Typed MercLocation Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, MercLocation mock)
		{
			mock.StkId = TestUtility.Instance.RandomString(5, false);;
			mock.LocId = TestUtility.Instance.RandomString(4, false);;
			mock.GoodsId = TestUtility.Instance.RandomString(6, false);;
			mock.Check = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
