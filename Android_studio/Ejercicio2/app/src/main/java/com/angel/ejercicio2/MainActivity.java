package com.angel.ejercicio2;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

//En este ejercicio se observara como acomodar los objetos para que sean responsive
public class MainActivity extends AppCompatActivity {
   TextView et1=findViewById(R.id.tv);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



    }
}