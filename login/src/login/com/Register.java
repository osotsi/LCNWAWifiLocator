package login.com;

import android.app.Activity;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

/**
 * register
 * 
 * @author F
 * 
 */
public class Register extends Activity implements OnClickListener{
	
	EditText userName01,password01,password02;
	Button back,register01;
	
	Sql db;
	SQLiteDatabase sDatabase = null;
	
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.register);
        
        userName01 = (EditText)findViewById(R.id.userName01);
        password01 = (EditText)findViewById(R.id.password01);
        password02 = (EditText)findViewById(R.id.password02);
        back = (Button)findViewById(R.id.back);
        register01 = (Button)findViewById(R.id.register01);
        
        back.setOnClickListener(this);
        register01.setOnClickListener(this);
        
		db = new Sql(getApplicationContext(), "store.db", null, 1);
		sDatabase = db.getWritableDatabase();
        
        
    }

	@Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		int id = v.getId();
		 if(id == R.id.back){ 
			 Intent intent = new Intent();
			 intent.setClass(Register.this, Login.class);
			 startActivity(intent);
		 }
		 
		 if(id == R.id.register01){
				db = new Sql(getApplicationContext(), "store.db", null, 1);
				sDatabase = db.getWritableDatabase();
				if (userName01.getText().toString().equals("")
						|| password01.getText().toString().equals("")
						|| password02.getText().toString().equals("")) {

					DialogDemo.builder(Register.this, "Error", "Full in all information");

				}else if (!password01.getText().toString()
						.equals(password02.getText().toString())) {
					DialogDemo.builder(Register.this, "Error", "Two times password not same");
				}else {
					String ename = userName01.getText().toString();
					String epass = password01.getText().toString();
					// find
					String selectStr = "select username from user_info";
					Cursor select_cursor = sDatabase.rawQuery(selectStr, null);
					select_cursor.moveToFirst();
					String string = null;
					do {
						try {
							string = select_cursor.getString(0);
						} catch (Exception e) {
							// TODO: handle exception
							string = "";
						}
						if (string.equals(ename)) {
							DialogDemo.builder(Register.this, "Error",
									"UserName exit, try another one");
							select_cursor.close();
							break;

						}
					}while (select_cursor.moveToNext());
					// re-register
					if (!string.equals(ename)) {
						// set ID
						int id1 = 0;
						String select = "select max(_id) from user_info";
						Cursor seCursor = sDatabase.rawQuery(select, null);
						try {
							seCursor.moveToFirst();
							id1 = Integer.parseInt(seCursor.getString(0));
							id1 += 1;
						} catch (Exception e) {
							// TODO: handle exception
							id1 = 0;
						}
						sDatabase.execSQL("insert into user_info values('" + id1 + "','"
								+ ename + "','" + epass + "')" 
								);
						DialogDemo.builder(Register.this, "Success", "Successful register, please return and log in");
						seCursor.close();
					
						
					}
				}
				
		 }
			
		}
		
	}



	
