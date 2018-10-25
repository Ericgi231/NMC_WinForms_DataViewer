﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_DataViewer.Models;
using Newtonsoft;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Bson;
using WinForms_DataViewer.Data;

namespace WinForms_DataViewer.DAL
{
    public class MongoDataService : IDataService
    {
        static string _connectionString;

        /// <summary>
        /// read the mongoDb collection and load a list of character objects
        /// </summary>
        /// <returns>list of characters</returns>
        public List<Character> ReadAll()
        {
            List<Character> characters = new List<Character>();

            try
            {
                var client = new MongoClient(_connectionString);
                IMongoDatabase database = client.GetDatabase("cit255");
                IMongoCollection<Character> characterList = database.GetCollection<Character>("soulcal_characters");

                characters = characterList.Find(Builders<Character>.Filter.Empty).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return characters;
        }

        /// <summary>
        /// write the current list of characters to the mongoDb collection
        /// </summary>
        /// <param name="characters">list of characters</param>
        public void WriteAll(List<Character> characters)
        {
            try
            {
                var client = new MongoClient(_connectionString);
                IMongoDatabase database = client.GetDatabase("cit255");
                IMongoCollection<Character> characterList = database.GetCollection<Character>("soulcal_characters");

                //
                // delete all documents in the collection to reset the collection
                //
                characterList.DeleteMany(Builders<Character>.Filter.Empty);

                characterList.InsertMany(characters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MongoDataService()
        {
            _connectionString = DataSettings.ConnectionString;
        }
    }
}
