package com.angel.ejercicio4;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    EditText et1, et2;

    TextView tv;
    Button b;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        et1 = findViewById(R.id.editT1);
        et2 = findViewById(R.id.editT2);
        tv = findViewById(R.id.tv1);
        b = findViewById(R.id.b1);




        suma();



    }

    public void suma() {


        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int r1 = Integer.parseInt(et1.getText().toString());
                int r2 = Integer.parseInt(et2.getText().toString());
                tv.setText(String.valueOf(r1 + r2));
            }


            });





       /* b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                tv.setText(String.valueOf(r1 + r2));
            }
        });*/
    }
}