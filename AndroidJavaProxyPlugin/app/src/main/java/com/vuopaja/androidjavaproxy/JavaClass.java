package com.vuopaja.androidjavaproxy;

import java.util.Random;

public class JavaClass
{
    public JavaCallback Callback;

    // The constructor takes a reference to the C# class
    // that implements the JavaCallback interface
    public JavaClass(JavaCallback callback)
    {
        Callback = callback;
    }

    public void JavaMethodName()
    {
        Random random = new Random();
        Callback.OnJavaCallback(random.nextInt(10));
    }
}
