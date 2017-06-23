﻿using PIWebAPIWrapper;
using PIWebAPIWrapper.Model;
using PIWebAPIWrapper.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PIWebApiClient client = new PIWebApiClient();
            bool connectionTest = client.DefineProperties("https://marc-web-sql.marc.net/piwebapi", true);
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
            ApiResponseObject response = client.Point.UpdateWithHttpInfo(webId, createdPoint);
            Console.WriteLine(response.StatusCode);

            PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
            PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu");
            PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
            string webIds = point1.WebId + "," + point1.WebId + "," + point1.WebId;
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
            Console.WriteLine(response.StatusCode);

          
            PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");
            Console.WriteLine(myElement.Description);
            PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, 1000, false, false, false, 0);
            Console.WriteLine(attributes);
            PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));
            PITimedValue value = client.Stream.GetEnd(attribute.WebId);
            Console.WriteLine(value);
        }
    }
}


