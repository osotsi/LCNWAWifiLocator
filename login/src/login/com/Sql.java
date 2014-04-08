package login.com;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.database.sqlite.SQLiteDatabase.CursorFactory;
//QLlite datebase
public class Sql extends SQLiteOpenHelper{
	
	//creat a new user
	String createUserTable = "create table user_info(_id int auto_increment,username char(20),"
		+ "password char(20),primary key('_id'));";
	
	// id username pw
	String insertStr = "insert into user_info(_id,username,password) values(?,?,?)";

	public Sql(Context context, String name, CursorFactory factory, int version) {
		super(context, name, factory, version);
		// TODO Auto-generated constructor stub
	}

	@Override
	public void onCreate(SQLiteDatabase db) {
		// TODO Auto-generated method stub
		int _id = 0; // primay key from 0
		//  create userTable
		db.execSQL(createUserTable);
		
		// insert data
		String[] insertValue = { "0", "admin", "admin" };//0 as admin
		db.execSQL(insertStr, insertValue);
	}

	@Override
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
		// TODO Auto-generated method stub
		
	}
	
}