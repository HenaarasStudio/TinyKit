using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("TinyKit/Variables")]
public class Variables : MonoBehaviour
{
    //[SerializeField]
    //public Dictionary<string, string> boz = new Dictionary<string, string>();

    public Dictionary<string, object> variables = new Dictionary<string, object>();
    void Start()
    {
        
    }

    public void Set(string VariableName, object Value)
    {
        //this.GetType().GetProperty(VariableName).SetValue(this, Value, null);
        variables[VariableName] = Value;
    }

    //public void Increase(string VariableName, object Value)
    //{
    //    this.GetType().GetProperty(VariableName).SetValue(this, Value, null);
    //    variables[VariableName] += Value;
    //}

    public void Reset(string VariableName)
    {
        variables[VariableName] = default;
        //this.GetType().GetProperty(VariableName).SetValue(this, default, null);
    }
}
