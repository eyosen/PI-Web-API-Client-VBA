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

	[Guid("2B6F6756-386D-4A6A-A163-B55D1FF60BB9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIEventFrame
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
		string TemplateName { get; set; }

		[DispId(7)]
		bool HasChildren { get; set; }

		[DispId(8)]
		string[] CategoryNames { get; set; }

		[DispId(9)]
		object ExtendedProperties { get; set; }

		[DispId(10)]
		string StartTime { get; set; }

		[DispId(11)]
		string EndTime { get; set; }

		[DispId(12)]
		string Severity { get; set; }

		[DispId(13)]
		string AcknowledgedBy { get; set; }

		[DispId(14)]
		string AcknowledgedDate { get; set; }

		[DispId(15)]
		bool CanBeAcknowledged { get; set; }

		[DispId(16)]
		bool IsAcknowledged { get; set; }

		[DispId(17)]
		bool IsAnnotated { get; set; }

		[DispId(18)]
		bool IsLocked { get; set; }

		[DispId(19)]
		bool AreValuesCaptured { get; set; }

		[DispId(20)]
		string[] RefElementWebIds { get; set; }

		[DispId(21)]
		PISecurity Security { get; set; }

		[DispId(22)]
		PIEventFrameLinks Links { get; set; }

		[DispId(23)]
		PIWebException WebException { get; set; }

	}

	[Guid("4F20BB1E-9C91-41CC-82AA-A35ABF6B7A9B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIEventFrame))]
	[ProgId("PIWebAPIWrapper.PIEventFrame")]
	[DataContract]

	public class PIEventFrame : IPIEventFrame
	{
		public PIEventFrame()
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

		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool HasChildren { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
		public object ExtendedProperties { get; set; }

		[DataMember(Name = "StartTime", EmitDefaultValue = false)]
		public string StartTime { get; set; }

		[DataMember(Name = "EndTime", EmitDefaultValue = false)]
		public string EndTime { get; set; }

		[DataMember(Name = "Severity", EmitDefaultValue = false)]
		public string Severity { get; set; }

		[DataMember(Name = "AcknowledgedBy", EmitDefaultValue = false)]
		public string AcknowledgedBy { get; set; }

		[DataMember(Name = "AcknowledgedDate", EmitDefaultValue = false)]
		public string AcknowledgedDate { get; set; }

		[DataMember(Name = "CanBeAcknowledged", EmitDefaultValue = false)]
		public bool CanBeAcknowledged { get; set; }

		[DataMember(Name = "IsAcknowledged", EmitDefaultValue = false)]
		public bool IsAcknowledged { get; set; }

		[DataMember(Name = "IsAnnotated", EmitDefaultValue = false)]
		public bool IsAnnotated { get; set; }

		[DataMember(Name = "IsLocked", EmitDefaultValue = false)]
		public bool IsLocked { get; set; }

		[DataMember(Name = "AreValuesCaptured", EmitDefaultValue = false)]
		public bool AreValuesCaptured { get; set; }

		[DataMember(Name = "RefElementWebIds", EmitDefaultValue = false)]
		public string[] RefElementWebIds { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public PISecurity Security { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIEventFrameLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
