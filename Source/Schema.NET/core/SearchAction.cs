﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ISearchAction : IAction
    {
        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        OneOrMany<string> Query { get; set; }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        Values<string, PropertyValueSpecification> QueryInput { get; set; }
    }

    /// <summary>
    /// The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SearchAction : Action, ISearchAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchAction";

        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        [DataMember(Name = "query", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Query { get; set; }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [DataMember(Name = "query-input", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, PropertyValueSpecification> QueryInput { get; set; }
    }
}
