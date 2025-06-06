package com.app.appholamundo;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    ImageButton bPush;
    TextView tvF;
    TextView tvName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        bPush=findViewById(R.id.bPush);
        tvF=findViewById(R.id.tvF);
        tvName=findViewById(R.id.tvName);
        bPush.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                bPush.setVisibility(View.INVISIBLE);
                tvF.setVisibility(View.VISIBLE);
                tvName.setVisibility(View.VISIBLE);

            }
        });
    }
}