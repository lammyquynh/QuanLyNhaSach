package com.example.dell.da_android;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentTransaction;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TabHost;

import com.google.firebase.database.DatabaseReference;


public class CartFragment extends Fragment {
    private DatabaseReference mDatabase ;
    private RecyclerView mRecyclerView;
    private RecyclerView.LayoutManager mLayoutManager;





    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        return inflater.inflate(R.layout.fragment_cart, null);
    }
}
//    @Nullable
//    @Override
//    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
//        View view = inflater.inflate(R.layout.fragment_store, container, false);
//
//        Button newGameButton = (Button) view.findViewById(R.id.btnThanhtoan);
//        newGameButton.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View view) {
//                storeFragment();
//            }
//        });
//        return view;
//    }
//
//    private void storeFragment(){
//        ThanhToan newGamefragment = new ThanhToan();
//        FragmentTransaction fragmentTransaction = getFragmentManager().beginTransaction();
//        fragmentTransaction.replace(R.id.btntaikhoan, newGamefragment);
//        fragmentTransaction.addToBackStack(null);
//        fragmentTransaction.commit();
//    }
//}