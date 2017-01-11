using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class Dummy
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }

    public Dummy(string name)
    {
        Name = name;
    }
}
