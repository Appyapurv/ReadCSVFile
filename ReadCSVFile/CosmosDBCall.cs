using Crestron.myCrestron.Configuration.Model;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReadCSVFile
{
    class CosmosDBCall
    {
        public void Main(string[] args)
        {
            CosmosDBCall ss = new CosmosDBCall();
            var c = ss.getValue().Result;
        }
        public async Task<object> getValue()
        {
            try
            {
                var client = new CosmosClient("https://prd-use-docdb-partitioned.documents.azure.com:443/", "S1yFhYXIEDHi2eZWgQa8MsakuhuratcAC0To1VmOevai8vJwmdIgIrQWyrVZuQ0rdB7LavqcExEL2P6ezyZ1cw==");
                var container = client.GetContainer("device", "Devices");



                //  var sql_syntax = "SELECT * FROM c Where c.AccountNumber != '{0}'";
                var sql_syntax = "SELECT * FROM c Where c.AccountId != null";
                // var sql = string.Format(sql_syntax, acct_number);
                var iterator = container.GetItemQueryIterator<dynamic>(sql_syntax);

                var deviceslist = new List<Device>();

                while (iterator.HasMoreResults)
                {
                    foreach (var item in iterator.ReadNextAsync().Result)
                    {
                        var rr = JsonConvert.DeserializeObject<Device>(item);


                        //  Result.Text = "SuccessFully updated";
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
