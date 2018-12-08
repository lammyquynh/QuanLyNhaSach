
package com.example.dell.da_android;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;

public class Login extends AppCompatActivity {
    EditText edtuser, edtpass;
    Button btndn, btndk;
    private FirebaseAuth mAuth;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        mAuth = FirebaseAuth.getInstance();
        AnhXa();

        btndn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DangNhap();
            }
        });


        btndk.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Login.this, Register.class);
                startActivity(intent);

            }
        });

    }
    private void AnhXa(){
        edtuser = findViewById(R.id.EditUser);
        edtpass = findViewById(R.id.EditPass);

        btndn = findViewById(R.id.buttonDangNhap);
        btndk = findViewById(R.id.buttonDangKy);
    }

    private void DangNhap()
    {
        String email = edtuser.getText().toString();
        String pass = edtpass.getText().toString();
        mAuth.signInWithEmailAndPassword(email, pass)
                .addOnCompleteListener(this, new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()) {
                            Toast.makeText(Login.this, "Đăng nhập thành công!",Toast.LENGTH_LONG).show();
                            Intent intent = new Intent(Login.this, MainActivity.class);
                            startActivityForResult(intent, 100);
                        } else {
                            Toast.makeText(Login.this, "Đăng nhập thất bại!",Toast.LENGTH_LONG).show();
                        }
                    }

                });
    }


}
