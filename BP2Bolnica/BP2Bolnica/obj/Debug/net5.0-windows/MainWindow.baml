   M S B A M L   `   `   `  ����E  ABP2Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BP2Bolnica
BP2Bolnica  5   	       BP2Bolnica.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BP2Bolnica     5   	   -   5          � Title$  Bolnica��5   
   $	��600��6   $
��1100��6'    � 	Resources 5	         bolnicaViewSource  zaposleniViewSource  zdravstveniRadnikViewSource  obezbedjenjeViewSource  spremacicaViewSource  doktorViewSource   medicinskiTehnicarViewSource  pacijentViewSource  pregledViewSource 	 obavljaPregledViewSource 
 intervencijaViewSource  opercionaSalaViewSource  odeljenjeViewSource��%y  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 �     �� 5
   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   5      .��5      � ���#1C1C1C.+�5   
   �� ���#1D1D1D$��0,0,0,35q�6*   .@�5      �� $��Bolnice��6   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ BolnicaDataGrid��5         AutoGenerateColumns$ False��5      ��5      ��  �� Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��5!   1      
IsReadOnly$
 True��5"   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5    -   �� *	IdBolnice+5"   1     5#      $ Naziv��5$   1    5#   -   �� *NazivBolnice+5$   1   5&      5'      �� 5*      $��	Zaposleni��6   .��5+        -   5        $ ZaposleniDataGrid��5+      $ False��5,      ��5-      �� # [  5.        5/      $ ID��50   1   $
 True��51   1    5/   -   �� *IdZaposlenog+51   1     52      $
 JMBG��53   1    52   -   �� *JmbgZ+53   1     54      $	 Ime��55   1    54   -   �� *ImeZ+55   1     56      $ Prezime��57   1    56   -   �� *
PrezimeZ+57   1     58      $ Plata (RSD)��59   1    58   -   �� *PlataZ+59   1     5;      $ Tip Zaposlenog��5<   1    5;   -   �� *TipZaposlenog+5<   1   4  .System.Windows.Controls.DataGridComboBoxColumn  5>      $ Radi u Bolnici��61   	   DisplayMemberPath$	 NazivBolnice��5@   1   
   SelectedValuePath$
 	IdBolnice��5B   1      ItemsSource 5?   1   �� # [     SelectedValueBinding 5A   1   �� *	IdBolnice+5B   1   5D      5E      �� 5H      $��Zdravstveni Radnik��6   .��5I        -   5        $ ZdravstveniRadnikDataGrid��5I      $ False��5J      ��5K      �� # [  5L        5M      $	 Ime��61   $
	 ImeZ��5O   1   $
 IdZaposlenog��5Q   1   $
 True��5R   1    5N   1   �� # [  5P   1   �� *IdZaposlenog+5R   1     5T      $ Prezime��61   $	 PrezimeZ��5V   1   $
 IdZaposlenog��5X   1   $
 True��5Y   1    5U   1   �� # [  5W   1   �� *IdZaposlenog+5Y   1     5[      $ Broj Licence��6-    5\   -   �� *BrojLicence+  5^      $ Tip Zdravstvenog Radnika��6-    5_   -   �� *	TipZdrRad+5b      5c      �� 5f      $��Obezbedjenje��6   .��5g        -   5        $ ObezbedjenjeDataGrid��5g      $ False��5h      ��5i      �� # [  5j        5k      $	 Ime��61   $
	 ImeZ��5m   1   $
 IdZaposlenog��5o   1   $
 True��5p   1    5l   1   �� # [  5n   1   �� *IdZaposlenog+5p   1     5r      $ Prezime��61   $	 PrezimeZ��5t   1   $
 IdZaposlenog��5v   1   $
 True��5w   1    5s   1   �� # [  5u   1   �� *IdZaposlenog+5w   1     5y      $ Dozvola Za Oruzje��6-    5z   -   �� *DozvolaZaOruzje+5}      5~      �� 5�      $��
Spremacica��6   .��5�        -   5        $ SpremacicaDataGrid��5�      $ False��5�      ��5�      �� # [  5�        5�      $	 Ime��61   $
	 ImeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1     5�      $ Prezime��61   $	 PrezimeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1     5�      $ Odeljenje koje odrzava��61   $	 NazivOdeljenja��5�   1   $
 IdOdeljenja��5�   1    5�   1   �� # [  5�   1   �� *IdOdeljenja+5�   1   5�      5�      �� 5�      $��Doktor��6   .��5�        -   5        $ DoktorDataGrid��5�      $ False��5�      ��5�      �� # [  5�        5�      $	 Ime��61   $
	 ImeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1     5�      $ Prezime��61   $	 PrezimeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1     5�      $ Specijalizacija��6-    5�   -   �� *Specijalizacija+5�      5�      �� 5�      $��Medicinski Tehnicar��6   .��5�        -   5        $  MedicinskiTehnicarDataGrid��5�      $ False��5�      ��5�      �� # [  5�        5�      $	 Ime��61   $
	 ImeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1     5�      $ Prezime��61   $	 PrezimeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1   5�      5�      �� 5�      $��Pacijent��6   .��5�        -	   5        $ PacijentDataGrid��5�      $ False��5�      ��5�      �� # [  5�        5�      $
 JMBG��5�   1    5�   -   �� *JmbgP+5�   1     5�      $	 Ime��5�   1    5�   -   �� *ImeP+5�   1     5�      $ Prezime��5�   1    5�   -   �� *
PrezimeP+5�   1     5�      $ Broj zdravstvene knjizice��5�   1    5�   -   �� *BrojZdrKnjiz+5�   1   5�      5�      �� 5�      $��Pregled��6   .��5�        -
   5        $ PregledDataGrid��5�      $ False��5�      ��5�      �� # [  5�        5�      $ ID��5�   1    5�   -   �� *IdP+5�   1     5�      $ Datum��5�   1    5�   -   �� *DatumP+5�   1     5�      $ Vreme��5�   1    5�   -   �� *VremeP+5�   1     5�      $ ID MedTeh Koji Zakazuje��61   $	 IdZaposlenog��5�   1   $
 IdZaposlenog��5�   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5�   1     5�      $ Broj Zdravstvene Knjizice��61   $	 BrojZdrKnjiz��5�   1   $
 BrojZdrKnjiz��5�   1    5�   1   �� # [  5�   1   �� *BrojZdrKnjiz+5�   1     5�      $ Pregled Zakazao Ime��61   $
	 ImeZ��5�   1   $
 IdZaposlenog��5�   1   $
 True��5   1    5�   1   �� # [  5�   1   �� *IdZaposlenog+5   1     5     $ Pregled Zakazao Prezime��61   $	 PrezimeZ��5  1   $
 IdZaposlenog��5  1   $
 True��5  1    5  1   �� # [  5  1   �� *IdZaposlenog+5  1     5	     $ Pacijent Ime��61   $
	 ImeP��5  1   $
 BrojZdrKnjiz��5  1   $
 True��5  1    5
  1   �� # [  5  1   �� *BrojZdrKnjiz+5  1     5     $ Pacijent Prezime��61   $	 PrezimeP��5  1   $
 BrojZdrKnjiz��5  1   $
 True��5  1    5  1   �� # [  5  1   �� *BrojZdrKnjiz+5  1   5     5     �� 5     $��Obavlja Pregled��6   .��5       -   5        $ ObavljaPregledDataGrid��5     $ False��5     ��5     �� # [	  5       5      $ 
ID Doktora��61   $	 IdZaposlenog��5"  1   $
 IdZaposlenog��5$  1    5!  1   �� # [  5#  1   �� *IdZaposlenog+5$  1     5&     $ 
Doktor Ime��61   $
	 ImeZ��5(  1   $
 IdZaposlenog��5*  1   $
 True��5+  1    5'  1   �� # [  5)  1   �� *IdZaposlenog+5+  1     5-     $ Doktor Prezime��61   $	 PrezimeZ��5/  1   $
 IdZaposlenog��51  1   $
 True��52  1    5.  1   �� # [  50  1   �� *IdZaposlenog+52  1     54     $ ID Pregleda��61   $		 IdP��56  1   $	
 IdP��58  1    55  1   �� # [  57  1   �� *IdP+58  1   5:     5;     �� 5>     $��	Odeljenje��6   .��5?       -   5        $ OdeljenjeDataGrid��5?     $ False��5@     ��5A     �� # [  5B       5C     $ ID��5D  1   $
 True��5E  1    5C  -   �� *IdOdeljenja+5E  1     5F     $ Naziv Odeljenja��5G  1    5F  -   �� *NazivOdeljenja+5G  1     5H     $ Sprat��5I  1    5H  -   �� *Sprat+5I  1   5K     5L     �� 5O     $��Operaciona Sala��6   .��5P       -   5        $ OperacionaSalaDataGrid��5P     $ False��5Q     ��5R     �� # [  5S       5T     $ Rb. Sale��5U  1   $
 True��5V  1    5T  -   �� *RbSale+5V  1     5X     $ 
Naziv Sale��5Y  1    5X  -   �� *	NazivSale+5Y  1     5[     $ 	Ima X-Ray��5\  1    5[  -   �� *	ImaXray+5\  1     5^     $ ID Odeljenja��61   $	 IdOdeljenja��5`  1   $
 IdOdeljenja��5b  1    5_  1   �� # [  5a  1   �� *IdOdeljenja+5b  1     5d     $ Sprat��61   $	 Sprat��5f  1   $
 IdOdeljenja��5h  1   $
 True��5i  1    5e  1   �� # [  5g  1   �� *IdOdeljenja+5i  1   5k     5l     �� 5o     $��Intervencija��6   .��5p       -   5        $ IntervencijaDataGrid��5p     $ False��5q     ��5r     �� # [
  5s       5t     $ ID��5u  1   $
 True��5v  1    5t  -   �� *IdI+5v  1     5x     $ Datum��5y  1    5x  -   �� *DatumI+5y  1     5{     $ Vreme��5|  1    5{  -   �� *VremeI+5|  1     5~     $ Trajanje (min)��5  1    5~  -   �� *	TrajanjeI+5  1     5�     $ 
ID Doktora��61   $	 IdZaposlenog��5�  1   $
 IdZaposlenog��5�  1    5�  1   �� # [  5�  1   �� *IdZaposlenog+5�  1     5�     $ 
Doktor Ime��61   $
	 ImeZ��5�  1   $
 IdZaposlenog��5�  1   $
 True��5�  1    5�  1   �� # [  5�  1   �� *IdZaposlenog+5�  1     5�     $ Doktor Prezime��61   $	 PrezimeZ��5�  1   $
 IdZaposlenog��5�  1   $
 True��5�  1    5�  1   �� # [  5�  1   �� *IdZaposlenog+5�  1     5�     $ ID Pregleda��61   $		 IdP��5�  1   $	
 IdP��5�  1    5�  1   �� # [  5�  1   �� *IdP+5�  1     5�     $ Rb. Sale��5�  1   $
 True��5�  1    5�  -   �� *RbSale+5�  1     5�     $ ID Odeljenja��61   $	 IdOdeljenja��5�  1   $
 IdOdeljenja��5�  1    5�  1   �� # [  5�  1   �� *IdOdeljenja+5�  1   5�     5�     5�     �� 5�  
   -   5        $��btnSave��5�     $
��Save��6    $��	0,0,10,10q�6/   $��20��6X   $��Bottom=�6d   $��Right=�6   $	��100��6�   5�     5�     