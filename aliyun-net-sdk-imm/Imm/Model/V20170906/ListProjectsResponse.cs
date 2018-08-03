/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class ListProjectsResponse : AcsResponse
	{

		private string requestId;

		private string nextMarker;

		private List<ListProjects_ProjectsItem> projects;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string NextMarker
		{
			get
			{
				return nextMarker;
			}
			set	
			{
				nextMarker = value;
			}
		}

		public List<ListProjects_ProjectsItem> Projects
		{
			get
			{
				return projects;
			}
			set	
			{
				projects = value;
			}
		}

		public class ListProjects_ProjectsItem
		{

			private string project;

			private string endpoint;

			private string serviceRole;

			private string createTime;

			private string modifyTime;

			private int? cU;

			private string type;

			private List<ListProjects_EnginesItem> engines;

			private List<ListProjects_IndexersItem> indexers;

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string Endpoint
			{
				get
				{
					return endpoint;
				}
				set	
				{
					endpoint = value;
				}
			}

			public string ServiceRole
			{
				get
				{
					return serviceRole;
				}
				set	
				{
					serviceRole = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public int? CU
			{
				get
				{
					return cU;
				}
				set	
				{
					cU = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public List<ListProjects_EnginesItem> Engines
			{
				get
				{
					return engines;
				}
				set	
				{
					engines = value;
				}
			}

			public List<ListProjects_IndexersItem> Indexers
			{
				get
				{
					return indexers;
				}
				set	
				{
					indexers = value;
				}
			}

			public class ListProjects_EnginesItem
			{

				private string name;

				private long? jobTtl;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public long? JobTtl
				{
					get
					{
						return jobTtl;
					}
					set	
					{
						jobTtl = value;
					}
				}
			}

			public class ListProjects_IndexersItem
			{

				private string name;

				private string status;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}