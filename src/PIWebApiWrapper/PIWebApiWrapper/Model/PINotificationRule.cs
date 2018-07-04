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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("ED5E85C4-4ADC-4857-AB47-BD14C89AEECC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPINotificationRule
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		string Path { get; set; }

		[DispId(6)]
		bool AutoCreated { get; set; }

		[DispId(7)]
		string[] CategoryNames { get; set; }

		[DispId(8)]
		string Criteria { get; set; }

		[DispId(9)]
		string MultiTriggerEventOption { get; set; }

		[DispId(10)]
		string NonrepetitionInterval { get; set; }

		[DispId(11)]
		string ResendInterval { get; set; }

		[DispId(12)]
		string Status { get; set; }

		[DispId(13)]
		string TemplateName { get; set; }

		[DispId(14)]
		PIWebException WebException { get; set; }

	}

	[Guid("C2A5A222-3354-4431-AC59-DA91FF727D9E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPINotificationRule))]
	[ProgId("PIWebAPIWrapper.PINotificationRule")]
	[DataContract]

	public class PINotificationRule : IPINotificationRule
	{
		public PINotificationRule()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "AutoCreated", EmitDefaultValue = false)]
		public bool AutoCreated { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "Criteria", EmitDefaultValue = false)]
		public string Criteria { get; set; }

		[DataMember(Name = "MultiTriggerEventOption", EmitDefaultValue = false)]
		public string MultiTriggerEventOption { get; set; }

		[DataMember(Name = "NonrepetitionInterval", EmitDefaultValue = false)]
		public string NonrepetitionInterval { get; set; }

		[DataMember(Name = "ResendInterval", EmitDefaultValue = false)]
		public string ResendInterval { get; set; }

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
