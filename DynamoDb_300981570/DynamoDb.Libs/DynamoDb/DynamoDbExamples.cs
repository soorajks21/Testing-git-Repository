using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamoDb.Libs.DynamoDb
{
   public class DynamoDbExamples : IDynamoDbExamples
    {
        private readonly IAmazonDynamoDB _dynamoDbClient;
        private static readonly string tablename = "TempDynamoDbTable";

        public  DynamoDbExamples(IAmazonDynamoDB dynamoDBClient)
        {
            _dynamoDbClient = dynamoDBClient;
        }

        public void CreateDynamoDbTable()
        {
            try
            {

                CreateTempTable();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CreateTempTable()
        {
            Console.WriteLine("Create table");

            var request = new CreateTableRequest
            {
                AttributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition
                    {
                        AttributeName = "Id",
                        AttributeType = "N"
                    },
                    new AttributeDefinition
                    {
                        AttributeName="ReplyDateTime",
                        AttributeType="N"
                    }
                },
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement
                    {
                        AttributeName = "Id",
                        KeyType = "HASH"
                    },

                    new KeySchemaElement
                    {
                        AttributeName = "ReplyDateTime",
                        KeyType = "Range"
                    }
                },

                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 5,
                    WriteCapacityUnits = 5

                },

                TableName = tablename
            };

        }
       
    }
}
