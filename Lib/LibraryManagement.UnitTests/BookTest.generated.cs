﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file BookTest.cs instead.
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
    /// Provides tests for the and <see cref="Book"/> objects (entity, collection and repository).
    /// </summary>
   public partial class BookTest
    {
    	// the Book instance used to test the repository.
		protected Book mock;
		
		// the TList<Book> instance used to test the repository.
		protected TList<Book> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the Book Entity with the {0} --", LibraryManagement.Dao.DataRepository.Provider.Name);
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
		/// Inserts a mock Book entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.BookProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.BookProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all Book objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.BookProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.BookProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.BookProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all Book children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.BookProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.BookProvider.DeepLoading += new EntityProviderBaseCore<Book, BookKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.BookProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("Book instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.BookProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock Book entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Book mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.BookProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.BookProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.BookProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock Book entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (Book)CreateMockInstance(tm);
				DataRepository.BookProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.BookProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.BookProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock Book entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Book.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock Book entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Book.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<Book>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a Book collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_BookCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<Book> mockCollection = new TList<Book>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<Book> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a Book collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_BookCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<Book>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<Book> mockCollection = (TList<Book>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<Book> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Book entity = CreateMockInstance(tm);
				bool result = DataRepository.BookProvider.Insert(tm, entity);
				
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
				Book entity = CreateMockInstance(tm);
				bool result = DataRepository.BookProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				Book t0 = DataRepository.BookProvider.GetByBookId(tm, entity.BookId);
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
				
				Book entity = mock.Copy() as Book;
				entity = (Book)mock.Clone();
				Assert.IsTrue(Book.ValueEquals(entity, mock), "Clone is not working");
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
				Book mock = CreateMockInstance(tm);
				bool result = DataRepository.BookProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				BookQuery query = new BookQuery();
			
				query.AppendEquals(BookColumn.BookId, mock.BookId.ToString());
				if(mock.BookCode != null)
					query.AppendEquals(BookColumn.BookCode, mock.BookCode.ToString());
				if(mock.BookName != null)
					query.AppendEquals(BookColumn.BookName, mock.BookName.ToString());
				if(mock.Author != null)
					query.AppendEquals(BookColumn.Author, mock.Author.ToString());
				if(mock.PublisherId != null)
					query.AppendEquals(BookColumn.PublisherId, mock.PublisherId.ToString());
				if(mock.BookCategoryId != null)
					query.AppendEquals(BookColumn.BookCategoryId, mock.BookCategoryId.ToString());
				if(mock.YearPublisher != null)
					query.AppendEquals(BookColumn.YearPublisher, mock.YearPublisher.ToString());
				if(mock.Quantity != null)
					query.AppendEquals(BookColumn.Quantity, mock.Quantity.ToString());
				if(mock.Description != null)
					query.AppendEquals(BookColumn.Description, mock.Description.ToString());
				
				TList<Book> results = DataRepository.BookProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed Book Entity with mock values.
		///</summary>
		static public Book CreateMockInstance_Generated(TransactionManager tm)
		{		
			Book mock = new Book();
						
			mock.BookCode = TestUtility.Instance.RandomString(24, false);;
			mock.BookName = TestUtility.Instance.RandomString(499, false);;
			mock.Author = TestUtility.Instance.RandomString(499, false);;
			mock.PublisherId = TestUtility.Instance.RandomString(9, false);;
			mock.BookCategoryId = TestUtility.Instance.RandomString(10, false);;
			mock.YearPublisher = TestUtility.Instance.RandomString(4, false);;
			mock.Quantity = TestUtility.Instance.RandomNumber();
			mock.Description = TestUtility.Instance.RandomString(499, false);;
			
		
			// create a temporary collection and add the item to it
			TList<Book> tempMockCollection = new TList<Book>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (Book)mock;
		}
		
		
		///<summary>
		///  Update the Typed Book Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, Book mock)
		{
			mock.BookCode = TestUtility.Instance.RandomString(24, false);;
			mock.BookName = TestUtility.Instance.RandomString(499, false);;
			mock.Author = TestUtility.Instance.RandomString(499, false);;
			mock.PublisherId = TestUtility.Instance.RandomString(9, false);;
			mock.BookCategoryId = TestUtility.Instance.RandomString(10, false);;
			mock.YearPublisher = TestUtility.Instance.RandomString(4, false);;
			mock.Quantity = TestUtility.Instance.RandomNumber();
			mock.Description = TestUtility.Instance.RandomString(499, false);;
			
		}
		#endregion
    }
}
