package com.angel.ejecicio1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.service.autofill.OnClickAction;
import android.view.View;
import android.widget.ImageView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

public void Action(View v, String n){
    Toast.makeText(getApplicationContext(),"Has presionado al "+n,Toast.LENGTH_SHORT).show();

}
    private ImageView im1,im2,im3,im4,im5,im6;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        im1 = (ImageView) findViewById(R.id.im1);
        im2 = (ImageView) findViewById(R.id.im2);
        im3 = (ImageView) findViewById(R.id.im3);
        im4 = (ImageView) findViewById(R.id.im4);
        im5 = (ImageView) findViewById(R.id.im5);
        im6 = (ImageView) findViewById(R.id.im6);

      im1.setOnClickListener(new View.OnClickListener() {
          @Override
          public void onClick(View v) {
              Action(v,"Perrito");
          }
      });
        im2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Action(v,"Osito Blanco");
            }
        });
        im3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Action(v,"Conejito");
            }
        });
        im4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Action(v,"Osito");
            }
        });
        im5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Action(v,"Perrito negro");
            }
        });
        im6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Action(v,"Perrito Gris");
            }
        });



    }

  /*  public void onClick(View v){
        Toast.makeText(getApplicationContext(), "Has presionado al animalito", Toast.LENGTH_LONG).show();
    }*/

}