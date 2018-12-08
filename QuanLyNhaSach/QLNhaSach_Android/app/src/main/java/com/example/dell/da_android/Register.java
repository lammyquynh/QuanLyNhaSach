package com.example.dell.da_android;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;

public class Register extends AppCompatActivity {
   private EditText edtuser, edtpass;
   private Button btndk, btntaikhoan;
    private FirebaseAuth mAuth;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        mAuth = FirebaseAuth.getInstance();
        AnhXa();

        btndk.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DangKy();
            }
        });

        btntaikhoan.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Register.this, Login.class);
                startActivity(intent);
            }
        });
    }

    private void AnhXa(){
        edtuser = findViewById(R.id.edtemail);
        edtpass = findViewById(R.id.edtpass);

        btndk = findViewById(R.id.btndk);
        btntaikhoan = findViewById(R.id.btntaikhoan);
    }

    private void DangKy() {
        String email = edtuser.getText().toString();
        String pass = edtpass.getText().toString();
            mAuth.createUserWithEmailAndPassword(email, pass)
                    .addOnCompleteListener(this, new OnCompleteListener<AuthResult>() {
                        @Override
                        public void onComplete(@NonNull Task<AuthResult> task) {
                            if (task.isSuccessful()) {
                                Toast.makeText(Register.this, "Đăng ký thành công!",Toast.LENGTH_LONG).show();
                            } else {
                                Toast.makeText(Register.this, "Đăng ký thất bại!",Toast.LENGTH_LONG).show();
                            }
                        }
                    });
    }
}
