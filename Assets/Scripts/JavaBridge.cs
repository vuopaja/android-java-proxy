using UnityEngine;
using System;

public class JavaBridge : AndroidJavaProxy
{
	public Action<int> GotJavaCallback;

	AndroidJavaObject javaObject;

	public JavaBridge() : base("com.vuopaja.androidjavaproxy.JavaCallback")
	{
		// We create an instance of the JavaClass in the constructor
		// and pass the reference of this class to the JavaClass
		javaObject = new AndroidJavaObject("com.vuopaja.androidjavaproxy.JavaClass", this);
	}
	
	// Call the method in the plugin to invoke the callback
	public void CallJavaMethod()
	{
		javaObject.Call("JavaMethodName");
	}

	// This method will be invoked from the plugin
	public void OnJavaCallback(int index)
	{
		// Pass the result to the C# event that we register to in the UI class
		if (GotJavaCallback != null) GotJavaCallback(index);
	}
}
