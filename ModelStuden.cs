using System;
using System.Collections.Generic;

public class ModelStuden{

    public ModelStuden(){}

    public string StudenID{ get; set;}
    public string StudenName{ get; set;}
    public int StudenAge{ get; set;}
    public string StudenPhon{ get; set;}

    public static implicit operator ModelStuden(List<ModelStuden> v)
    {
        throw new NotImplementedException();
    }
}