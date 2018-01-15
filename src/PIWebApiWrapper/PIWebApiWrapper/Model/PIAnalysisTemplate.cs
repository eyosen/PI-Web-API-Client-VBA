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

	[Guid("6ED83F97-924C-4D1B-B9BD-F86A6BF7E4E3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysisTemplate
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
		string AnalysisRulePlugInName { get; set; }

		[DispId(7)]
		string[] CategoryNames { get; set; }

		[DispId(8)]
		bool CreateEnabled { get; set; }

		[DispId(9)]
		int GroupId { get; set; }

		[DispId(10)]
		bool HasNotificationTemplate { get; set; }

		[DispId(11)]
		bool HasTarget { get; set; }

		[DispId(12)]
		string OutputTime { get; set; }

		[DispId(13)]
		string TargetName { get; set; }

		[DispId(14)]
		string TimeRulePlugInName { get; set; }

		[DispId(15)]
		object Links { get; set; }

	}

	[Guid("3FC92889-878F-4AD9-B258-4C381A20FDE4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.PIAnalysisTemplate")]
	[DataContract]

	public class PIAnalysisTemplate : IPIAnalysisTemplate
	{
		public PIAnalysisTemplate()
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

		[DataMember(Name = "AnalysisRulePlugInName", EmitDefaultValue = false)]
		public string AnalysisRulePlugInName { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "CreateEnabled", EmitDefaultValue = false)]
		public bool CreateEnabled { get; set; }

		[DataMember(Name = "GroupId", EmitDefaultValue = false)]
		public int GroupId { get; set; }

		[DataMember(Name = "HasNotificationTemplate", EmitDefaultValue = false)]
		public bool HasNotificationTemplate { get; set; }

		[DataMember(Name = "HasTarget", EmitDefaultValue = false)]
		public bool HasTarget { get; set; }

		[DataMember(Name = "OutputTime", EmitDefaultValue = false)]
		public string OutputTime { get; set; }

		[DataMember(Name = "TargetName", EmitDefaultValue = false)]
		public string TargetName { get; set; }

		[DataMember(Name = "TimeRulePlugInName", EmitDefaultValue = false)]
		public string TimeRulePlugInName { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
