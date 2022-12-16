class Jogador
{
private string nome;
private int gols;
public void SetNome (string n)
{
nome = n;
}
public void SetGols(int g)
{
if (g >= 0) gols = g;
}
public int GetGols()
{
return gols;
}
public override string ToString()
{
if (gols == 0)
return $"{nome} - nenhum gol";
if (gols == 1)
return $"{nome} - um gol"
return $"{nome} - {gols} - gols";
}
private Jogadpr [] js = new Jogador [10]
private int k;

/*private void Button_Click(object sender, RoutedEvent);*\
{
Jogador j = new = Jogador();
j.SetNome(txt1.Text);
j.SetGols(int.Parse(txt2.Text));
js[k] = j;
k++;
list.ItensSource = null;
list.ItensSource = js;
}
/*private void Artilheiro_Click(object sender, RoutedEvent);*\
{
if (k==0)
{ 
  MessageBox.Show("nenhum jogador foi inserido");
return;
}
jogador  aux  = js[0];
for (int i = 1; i < k; i++)
  if (js[i].GetGols() > aux.GetGols())
    aux = js[i];
MessageBox.Show(aux.ToString());
}
}
