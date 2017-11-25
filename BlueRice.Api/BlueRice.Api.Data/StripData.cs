using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon.S3;
using Amazon.S3.Model;
using BlueRice.Api.Common.Models;
using CsvHelper;

namespace BlueRice.Api.Data
{
    public interface IStripData
    {
        Strip GetStrip(int id);
    }

    public class StripData : IStripData
    {
        public Strip GetStrip(int id)
        {
            var records = new List<Strip>();

            using (var client = new AmazonS3Client(Amazon.RegionEndpoint.USEast1))
            {
                var request = new GetObjectRequest {
                    BucketName = "bluerice",
                    Key = "data/strips.csv"
                };
               
                var response = client.GetObjectAsync(request).Result;

                using (var rsponseStream = response.ResponseStream)
                {
                    using (var reader = new StreamReader(rsponseStream))
                    {
                        using (var csv = new CsvReader(reader))
                        {
                            while (csv.Read()) {
                                var record = csv.GetRecord<Strip>();
                                records.Add(record);
                            }
                        };
                    };
                }
            }

            return records.Single(x => x.Id == id);
        }
    }
}
