PI Web API Wrapper for VBA (2017 R2)
===

## Overview
This repository has the source code package of the PI Web API Wrapper for VBA. This version was developed on top of the PI Web API 2017 R2 swagger specification. 

## Requirements

 - PI Web API 2017 R2 installed within your domain using Kerberos or Basic Authentication. If you are using an older version, some methods might not work.
 - PI ProcessBook 2012 SP1+
 - .NET Framework 3.5  


## Installation

 - Download this source code
 - Create a new folder under %PIHOME% named WebAPIClient, if it doesn't exist.
 - Create a new folder under WebAPIClient named VBA, if it doesn't exist.
 - Copy all files from the dist folder to %PIHOME%\WebAPIClient\VBA.
 - Run as Administrator the reg.bat located on %PIHOME%\WebAPIClient\VBA in order to register the PIWebApiWrapper assmebly.


## Usage

Create or edit a PI ProcessBook display. Press ALT+F11 to open Visual Basic for Applications. On the menu, click on Tools --> References. Find PIWebApiWrapper on the list box of the available reference and add it to the VBA project.

## Source code
The Visual Studio solution that generates the final library is available on the src folder. You might want to add or edit a method and rebuild the solution in order to generate custom assemblies.

## Documentation

All classes and methods are described on the [DOCUMENTATION](DOCUMENTATION.md). You can also use the Object Browser from Visual Basic for Application to read the same information.


## Remember

As this is a .NET library with COM objects and methods exposed to be able be consumed within the VBA environment, there are some things to have in mind, specially when comparing with C# development.

 - VBA is not compatible with async methods. Therefore, only sync methods are available in this library.
 - For each PI Web API action/method of each controller, there are two methods on this client library. One returns the response of the HTTP request itself and the other wraps the response on top of ApiResponse class, providing http information, such as status code. Please refer to the [**Get**](docs/Api/HomeApi.md#get) and [**GetWithHttpInfo**](docs/Api/HomeApi.md#getwithhttpinfo) methods on our documentation and you will realize the difference between them by comparing the method signature.
 - The Batch and Channel controllers are not exposed.
 - When working with data transfer objects (models) with an Items property (such as PIItemsElement), do not access or modify this property directly. Use CreateItemsArray(), GetItem(), SetItem() and GetItemsLength() instead.
 - For models that have the Value property, use SetValueWithString(), SetValueWithInt(), SetValueWithDouble() methods to set this property.
 - For the Api methods, all variables whose type are not a string must be defined. If a string variable is optional, define it as an empty string instead of Null. 
 - Is is highly recommended to turn debug mode on in case you are using PI Web API 2017 R2+ in order to receive more detailed exception errors. This can be achieved by creating or editing the DebugMode attribute's value to TRUE from the System Configuration element.
 - The X-Requested-With header is added to work with CSRF defences.
 
## Feedback 

Plese provide feedback by commenting the related [PI Developer Club blog post](https://pisquare.osisoft.com/community/developers-club/blog/2017/07/10/announcing-pi-web-api-wrapper-for-vba).
 
 
## Examples

There are two PI ProcessBook displays available on the Samples folder of this repository. In addition, please refer to the following examples to understand how to use this library: 


### Create an instance of the PI Web API top level object using Kerberos authentication.

```vb# 
    Dim client As New PIWebApiClient
    Dim connectedToPIWebAPI As Boolean
    connectedToPIWebAPI = client.Connect("https://marc-web-sql.marc.net/piwebapi", True)
``` 

### Create an instance of the PI Web API top level object using Basic authentication.

```vb# 
    Dim client As New PIWebApiClient
    Dim connectedToPIWebAPI As Boolean
    connectedToPIWebAPI = client.Connect("https://marc-web-sql.marc.net/piwebapi", False, username, password) 
``` 


If you want to use basic authentication instead of Kerberos, set useKerberos to False and set the username and password accordingly. We recommend using Kerberos because it is the safest option. For basic authentication, the password needs to be hardcoded which is not recommended. If using Kerberos authentication is not an option, protect your VBA code with a password.

### Get the PI Data Archive WebId

```vb# 
    Set dataServer = client.dataServer.GetByName(tbPIDataArchiveName.Text)
```

### Create a new PI Point

```vb# 
    Dim response As ApiResponseObject
    Dim newPIPoint As New PIPoint
    newPIPoint.Name = "MyNewPIPoint"
    newPIPoint.Descriptor = "Point created for wrapper test"
    newPIPoint.PointClass = "classic"
    newPIPoint.PointType = "Float32"
    Set response = client.dataServer.CreatePointWithHttpInfo(dataServer.webId, newPIPoint)
```

### Get PI Points WebIds

```vb# 
    Set point1 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName1.Text)
    Set point2 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName2.Text)
    Set point3 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName3.Text)
```

### Get recorded values in bulk using the StreamSet/GetRecordedAdHoc

```vb# 
    webIds = point1.webId + "," + point2.webId + "," + point3.webId
    Set compressedData = client.StreamSet.GetRecordedAdHoc(webIds, True, 1000)
```

### Send values in bulk using the StreamSet/UpdateValuesAdHoc

```vb# 
    Call GetPIPoints
    Dim streamValuesItems As New PIItemsStreamValues
    Dim streamValue1 As New PIStreamValues
    Dim streamValue2 As New PIStreamValues
    Dim streamValue3 As New PIStreamValues
    Dim value1 As New PITimedValue
    Dim value2 As New PITimedValue
    Dim value3 As New PITimedValue
    Dim value4 As New PITimedValue
    Dim value5 As New PITimedValue
    Dim value6 As New PITimedValue

    streamValuesItems.CreateItemsArray (3)
    value1.SetValueWithInt (2)
    value1.Timestamp = "*-1d"
    value2.SetValueWithInt (3)
    value2.Timestamp = "*-2d"
    value3.SetValueWithInt (4)
    value3.Timestamp = "*-1d"
    value4.SetValueWithInt (5)
    value4.Timestamp = "*-2d"
    value5.SetValueWithInt (6)
    value5.Timestamp = "*-1d"
    value6.SetValueWithInt (7)
    value6.Timestamp = "*-2d"

    streamValue1.webId = point1.webId
    streamValue1.CreateItemsArray (2)
    Call streamValue1.SetItem(0, value1)
    Call streamValue1.SetItem(1, value2)
    Call streamValuesItems.SetItem(0, streamValue1)

    streamValue2.webId = point2.webId
    streamValue2.CreateItemsArray (2)
    Call streamValue2.SetItem(0, value3)
    Call streamValue2.SetItem(1, value4)
    Call streamValuesItems.SetItem(1, streamValue2)

    streamValue3.webId = point2.webId
    streamValue3.CreateItemsArray (2)
    Call streamValue3.SetItem(0, value5)
    Call streamValue3.SetItem(1, value6)
    Call streamValuesItems.SetItem(2, streamValue3)

    Dim response As ApiResponsePIItemsItemsSubstatus
    Set response = client.StreamSet.UpdateValuesAdHocWithHttpInfo(streamValuesItems)
```


### Get AF Attribute given an AF Element path

```vb# 
    Set elem = client.element.GetByPath(ERD.CurrentContext(ThisDisplay))
    ElemDesc.Contents = elem.Description
    Dim attributes As PIItemsAttribute
    Set attributes = client.element.GetAttributes(elem.webId, 1000, False, False, False, 0)
```


### Get current value given an AF Attribute path

```vb# 
    attributePath = ERD.CurrentContext(ThisDisplay) + "|" + AttrList.Text
    Set attr = client.attribute.GetByPath(attributePath)
    Set timedValue = client.Stream.GetEnd(attr.webId)
    AttrValue.Contents = timedValue.value
```

### Get Event Frames given an AF database path

```vb# 
    Set db = client.AssetDatabase.GetByPath(dbPath)
    Set efs = client.AssetDatabase.GetEventFrames(db.webId, False, False, 100, True, 0, "", "*", "", elem.Name, elem.templateName, "", "", "None", "", "", "*-900", "", "")
```


## Licensing
Copyright 2017 OSIsoft, LLC.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   
Please see the file named [LICENSE.md](LICENSE.md).
