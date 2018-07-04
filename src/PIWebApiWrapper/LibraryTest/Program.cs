// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************


using PIWebAPIWrapper;
using PIWebAPIWrapper.Model;
using PIWebAPIWrapper.Responses;
using PIWebAPIWrapper.WebID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;


namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PIWebApiClient client = new PIWebApiClient();

            bool connectionTest = client.Connect("https://marc-web-sql.marc.net/piwebapi", true);
            if (connectionTest == false)
            {
                return;
            }
            PIDataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2016");
            PIPoint createdPoint = client.Point.GetByPath("\\\\MARC-PI2016\\SINUSOIDR1259", null);
            string webId = createdPoint.WebId;
            createdPoint.DigitalSetName = null;
            createdPoint.EngineeringUnits = null;
            createdPoint.Descriptor = "14 Hour Sine Waveeeeee";
            createdPoint.Future = false;
            createdPoint.Id = 0;
            createdPoint.Links = null;
            createdPoint.Name = null;
            createdPoint.Path = null;
            createdPoint.PointClass = null;
            createdPoint.PointType = null;
            createdPoint.WebId = null;
            createdPoint.Span = 0;
            createdPoint.Zero = 0;
            ApiResponseObject response = client.Point.UpdateWithHttpInfo(webId, createdPoint);
            Console.WriteLine(response.StatusCode);

            PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
            PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu");
            PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
            string webIds = point1.WebId + "," + point2.WebId + "," + point3.WebId;
            PIItemsStreamValues piItemsStreamValues = client.StreamSet.GetRecordedAdHoc(webIds, true, 10000);
            for (int i = 0; i < piItemsStreamValues.GetItemsLength(); i++)
            {
                Console.WriteLine(piItemsStreamValues.GetItem(i).Path);
                for (int j = 0; j < piItemsStreamValues.GetItem(i).GetItemsLength(); j++)
                {
                    Console.WriteLine(piItemsStreamValues.GetItem(i).GetItem(j).Value);
                }
            }

            PIItemsStreamValues streamValuesItems = new PIItemsStreamValues();
            streamValuesItems.CreateItemsArray(3);

            PITimedValue value1 = new PITimedValue();
            value1.Value = 2;
            value1.Timestamp = "*-1d";
            PITimedValue value2 = new PITimedValue();
            value2.Value = 3;
            value2.Timestamp = "*-2d";
            PITimedValue value3 = new PITimedValue();
            value3.Value = 4;
            value3.Timestamp = "*-1d";
            PITimedValue value4 = new PITimedValue();
            value4.Value = 5;
            value4.Timestamp = "*-2d";
            PITimedValue value5 = new PITimedValue();
            value5.Value = 6;
            value5.Timestamp = "*-1d";
            PITimedValue value6 = new PITimedValue();
            value6.Value = 7;
            value6.Timestamp = "*-2d";




            PIStreamValues streamValue1 = new PIStreamValues();
            streamValue1.WebId = point1.WebId;
            streamValue1.CreateItemsArray(2);
            streamValue1.SetItem(0, value1);
            streamValue1.SetItem(1, value2);
            streamValuesItems.SetItem(0, streamValue1);

            PIStreamValues streamValue2 = new PIStreamValues();
            streamValue2.WebId = point2.WebId;
            streamValue2.CreateItemsArray(2);
            streamValue2.SetItem(0, value3);
            streamValue2.SetItem(1, value4);
            streamValuesItems.SetItem(1, streamValue2);

            PIStreamValues streamValue3 = new PIStreamValues();
            streamValue3.WebId = point2.WebId;
            streamValue3.CreateItemsArray(2);
            streamValue3.SetItem(0, value5);
            streamValue3.SetItem(1, value6);
            streamValuesItems.SetItem(2, streamValue3);

            ApiResponsePIItemsItemsSubstatus responsee = client.StreamSet.UpdateValuesAdHocWithHttpInfo(streamValuesItems);

            PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");
            Console.WriteLine(myElement.Description);
            PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, 1000, false, false, false, 0);
            Console.WriteLine(attributes);
            PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));
            PITimedValue value = client.Stream.GetEnd(attribute.WebId);
            Console.WriteLine(value);



            string expression = "'sinusoid'*2 + 'cdt158'";
            PITimedValues values1 = client.Calculation.GetAtTimes(webId: dataServer.WebId, expression: expression, times: "*-1d, *-2d");

            string expression2 = "'cdt158'+tagval('sinusoid','*-1d')";
            PITimedValues values2 = client.Calculation.GetAtTimes(webId: dataServer.WebId, expression: expression2, times: "*-1d, *-2d");

            PIItemsSummaryValue itemsSummaryValue = client.Calculation.GetSummary(expression: expression2, startTime: "*-1d", endTime: "*", webId: dataServer.WebId,
                summaryTypes: "Average, Maximum");



            //Get the attribute's end of the stream value
            PITimedValue newValue = client.Stream.GetEnd(attribute.WebId);


            //Stream Updates
            PIItemsStreamUpdatesRegister piItemsStreamUpdatesRegister = client.StreamSet.RegisterStreamSetUpdates(webIds);
            List<string> markersList = piItemsStreamUpdatesRegister.Items.Select(i => i.LatestMarker).ToList();
            string markers = String.Join(",", markersList.ToArray());
            int k = 3;
            while (k > 0)
            {
                PIItemsStreamUpdatesRetrieve piItemsStreamUpdatesRetrieve = client.StreamSet.RetrieveStreamSetUpdates(markers);
                markersList = piItemsStreamUpdatesRetrieve.Items.Select(i => i.LatestMarker).ToList();
                markers = String.Join(",", markersList.ToArray());
                foreach (PIStreamUpdatesRetrieve item in piItemsStreamUpdatesRetrieve.Items)
                {
                    foreach (PIDataPipeEvent piEvent in item.Events)
                    {
                        Console.WriteLine("Action={0}, Value={1}, SourcePath={2}", piEvent.Action, piEvent.Value, item.SourcePath);
                    }
                }
                System.Threading.Thread.Sleep(30000);
                k--;
            }

        }
    }
}


