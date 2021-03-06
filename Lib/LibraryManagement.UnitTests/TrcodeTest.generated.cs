﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file TrcodeTest.cs instead.
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
    /// Provides tests for the and <see cref="Trcode"/> objects (entity, collection and repository).
    /// </summary>
   public partial class TrcodeTest
    {
    	// the Trcode instance used to test the repository.
		protected Trcode mock;
		
		// the TList<Trcode> instance used to test the repository.
		protected TList<Trcode> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the Trcode Entity with the {0} --", LibraryManagement.Dao.DataRepository.Provider.Name);
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
		/// Inserts a mock Trcode entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TrcodeProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.TrcodeProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all Trcode objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.TrcodeProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.TrcodeProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.TrcodeProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all Trcode children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.TrcodeProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.TrcodeProvider.DeepLoading += new EntityProviderBaseCore<Trcode, TrcodeKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.TrcodeProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("Trcode instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.TrcodeProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock Trcode entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Trcode mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TrcodeProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.TrcodeProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.TrcodeProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock Trcode entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (Trcode)CreateMockInstance(tm);
				DataRepository.TrcodeProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.TrcodeProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.TrcodeProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock Trcode entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Trcode.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock Trcode entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Trcode.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<Trcode>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a Trcode collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TrcodeCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<Trcode> mockCollection = new TList<Trcode>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<Trcode> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a Trcode collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TrcodeCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<Trcode>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<Trcode> mockCollection = (TList<Trcode>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<Trcode> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Trcode entity = CreateMockInstance(tm);
				bool result = DataRepository.TrcodeProvider.Insert(tm, entity);
				
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
				Trcode entity = CreateMockInstance(tm);
				bool result = DataRepository.TrcodeProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				Trcode t0 = DataRepository.TrcodeProvider.GetByTrCode(tm, entity.TrCode);
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
				
				Trcode entity = mock.Copy() as Trcode;
				entity = (Trcode)mock.Clone();
				Assert.IsTrue(Trcode.ValueEquals(entity, mock), "Clone is not working");
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
				Trcode mock = CreateMockInstance(tm);
				bool result = DataRepository.TrcodeProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				TrcodeQuery query = new TrcodeQuery();
			
				query.AppendEquals(TrcodeColumn.TrCode, mock.TrCode.ToString());
				if(mock.TrName != null)
					query.AppendEquals(TrcodeColumn.TrName, mock.TrName.ToString());
				query.AppendEquals(TrcodeColumn.Description, mock.Description.ToString());
				if(mock.TrDepart != null)
					query.AppendEquals(TrcodeColumn.TrDepart, mock.TrDepart.ToString());
				if(mock.FrmCaption != null)
					query.AppendEquals(TrcodeColumn.FrmCaption, mock.FrmCaption.ToString());
				if(mock.VoucherFile != null)
					query.AppendEquals(TrcodeColumn.VoucherFile, mock.VoucherFile.ToString());
				if(mock.VoucherFile1 != null)
					query.AppendEquals(TrcodeColumn.VoucherFile1, mock.VoucherFile1.ToString());
				if(mock.VoucherFile2 != null)
					query.AppendEquals(TrcodeColumn.VoucherFile2, mock.VoucherFile2.ToString());
				if(mock.Status != null)
					query.AppendEquals(TrcodeColumn.Status, mock.Status.ToString());
				
				TList<Trcode> results = DataRepository.TrcodeProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed Trcode Entity with mock values.
		///</summary>
		static public Trcode CreateMockInstance_Generated(TransactionManager tm)
		{		
			Trcode mock = new Trcode();
						
			mock.TrCode = TestUtility.Instance.RandomString(2, false);;
			mock.TrName = TestUtility.Instance.RandomString(99, false);;
			mock.Description = TestUtility.Instance.RandomString(2, false);;
			mock.TrDepart = TestUtility.Instance.RandomString(1, false);;
			mock.FrmCaption = TestUtility.Instance.RandomString(24, false);;
			mock.VoucherFile = TestUtility.Instance.RandomString(9, false);;
			mock.VoucherFile1 = TestUtility.Instance.RandomString(9, false);;
			mock.VoucherFile2 = TestUtility.Instance.RandomString(9, false);;
			mock.Status = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<Trcode> tempMockCollection = new TList<Trcode>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (Trcode)mock;
		}
		
		
		///<summary>
		///  Update the Typed Trcode Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, Trcode mock)
		{
			mock.TrName = TestUtility.Instance.RandomString(99, false);;
			mock.Description = TestUtility.Instance.RandomString(2, false);;
			mock.TrDepart = TestUtility.Instance.RandomString(1, false);;
			mock.FrmCaption = TestUtility.Instance.RandomString(24, false);;
			mock.VoucherFile = TestUtility.Instance.RandomString(9, false);;
			mock.VoucherFile1 = TestUtility.Instance.RandomString(9, false);;
			mock.VoucherFile2 = TestUtility.Instance.RandomString(9, false);;
			mock.Status = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
