#include<bits/stdc++.h>
using namespace std;
/*
Project Study
Physics Formulas
Hope active users can add something new into it
*/
const int N = 2e3+10;
int tot = 0,uc,pos[N],dead[N];
string disc[N],ans[N],ui;
void readVars(){
	ifstream input("library.txt");
	input>>tot;
	string tmp;
	getline(input,tmp);
	for (int i=1;i<=tot;i++){
		getline(input,disc[i]);
		getline(input,ans[i]);
	}
	for (int i=1;i<=tot;i++) input>>dead[i];
}
void writeVars(){
	ofstream output("library.txt");
	output<<tot<<endl;
	for (int i=1;i<=tot;i++) output<<disc[i]<<endl<<ans[i]<<endl;
	for (int i=1;i<=tot;i++) output<<dead[i]<<endl;
}
void nxp(){
	char s[15];
	getchar();
	cin.getline(s,10);
}
void rev(){
	system("cls");
	for (int i=1;i<=tot;i++) pos[i] = i;
	int flag = 0;
	srand(time(0));
	random_shuffle(pos+1,pos+1+tot);
	int cor = 0,num = 0;
	for (int i=1;i<=tot;i++){
		if (dead[pos[i]]) continue;
		system("cls");
		num++;
		flag = 1;
		cout<<"Question:"<<endl<<disc[pos[i]]<<endl;
		cin>>ui;
		if (ui == ans[pos[i]]){
			cout<<"Correct!"<<endl;
			cor++;
		}
		else{
			cout<<endl;
			cout<<"Please check it yourself, the order may not be the same as the answer"<<endl;
			cout<<"Answer:"<<endl<<ans[pos[i]]<<endl;
		}
		cout<<endl<<"Press any key to continue"<<endl;
		nxp();
	}
	system("cls");
	if (!flag) cout<<"There are nothing in your library now"<<endl,getchar();
	else {
		cout<<"Congratulations! You have finished all of them!"<<endl;
		double gra = (double)cor/num*100;
		cout<<"Grade: "<<fixed<<setprecision(2)<<gra<<endl;
	}
	getchar();
}
void imp(int tot){
	system("cls");
	cout<<"Please input the description of your question"<<endl;
	cin>>disc[tot];
	system("cls");
	cout<<"Please input the answer"<<endl;
	cin>>ans[tot];
}
void del(){
	system("cls");
	for (int i=0;i<=tot/10;i++){
		cout<<"Choose an item, or use -1 to terminate this process"<<endl;
		cout<<"Press A or D to go to previous or next page"<<endl;
		for (int j=i*10+1;j<=min(tot,(i+1)*10);j++) cout<<j<<"."<<disc[j]<<"\n";
		string s;
		cin>>s;
		if (s == "A" || s == "a"){
			system("cls");
			i-=2;
			i = max(i,-1);
			continue;
		}
		else if (s == "D" || s == "d"){
			system("cls");
			i = min(i,tot/10-1);
			continue;
		}
		else if (s == "-1") return;
		else{
			long long num = 0;
			int len = s.length();
			cout<<len<<endl;
			for (int j=0;j<len;j++) num = num*10+(s[j]-'0');
			cout<<num<<endl;
			system("cls");
			if (num>tot){
				cout<<"Out of bounds"<<endl;
				nxp();
				del();
				return;
			}
			system("cls");
			cout<<"Information:"<<endl;
			cout<<disc[num]<<endl<<ans[num]<<endl;
			if (!dead[num]) cout<<"1.Delete it"<<endl;
			else cout<<"1.Recover it"<<endl;
			cout<<"2.Change it"<<endl<<"3.Back"<<endl;
			int ch;
			cin>>ch;
			if (ch == 1) dead[num] = 1-dead[num];
			else if (ch == 2) imp(num);
			else del();
		}
	}
}
void menu(){
	system("cls");
	cout<<"1.Review"<<endl<<"2.Import"<<endl<<"3.Manage"<<endl<<"4.Exit"<<endl;
	cin>>uc;
	if (uc == 1) rev();
	else if (uc == 2){
		tot++;
		imp(tot);
		writeVars();
	}
	else if (uc == 3){
		del();
		writeVars();
	}
}
int main(){
	readVars();
	while (uc!=4) menu();
	return 0;
}

