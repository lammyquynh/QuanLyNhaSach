//package com.example.dell.da_android;
//
//import android.content.Context;
//import android.support.annotation.NonNull;
//import android.support.annotation.Nullable;
//import android.view.LayoutInflater;
//import android.view.View;
//import android.view.ViewGroup;
//import android.widget.ArrayAdapter;
//import android.widget.ImageView;
//import android.widget.TextView;
//
//import java.util.ArrayList;
//
//public class BooksAdapter extends ArrayAdapter {
//
//    Context context;
//    ArrayList<Books> arrayList;
//    int layout;
//
//    public BooksAdapter(@NonNull Context context, int resource, @NonNull ArrayList<Books> objects) {
//        super(context, resource, objects);
//        this.context = context;
//        this.arrayList = objects;
//        this.layout = resource;
//    }
//
//    @NonNull
//    @Override
//    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
//
//        Books b = arrayList.get(position);
//
//        if(convertView == null){
//            convertView = LayoutInflater.from(context).inflate(layout,null);
//        }
//
//        ImageView img = convertView.findViewById(R.id.imageSach);
//        img.setImageResource(b.getId());
//        TextView txtten = convertView.findViewById(R.id.txtTen);
//        txtten.setText(b.getTen());
//        TextView txtgia = convertView.findViewById(R.id.txtGia);
//        txtgia.setText(b.getGia());
//
//        return convertView;
//    }
//}
