   M S B A M L   `   `   `  ����I  EEpidemicDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EpidemicDesignEpidemicDesign  5   	       EpidemicDesign.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:EpidemicDesign     5   	   -   5          � Title$^  XСравнение на различните епидемии през годините.��5   	   $	��435��6A   $	��625��6N   .��5	      � .+�5
   
   (�  (� Stretch$
 None=�6   $��
0,0,0,-0.5q�6!   67   �� 5   
   -   5         ��Name$ Opening��5      $
��Left=�6%   $��131,30,147,0q�6@   $
��Wrap=�6V   $����2020г. започна лошо за целия свят. Избери период - научи някои факти за световните пандемии и ги сравни с COVID-19. ��6j   $	��Top=�6�   $	��242��6�   $��Segoe UI Semibold)�6
   �� TextAlignment$ Center=�6)  �� 5   
   -   5         ��Name$ yearComboBox��5      $
��Left=�6)   $��228,103,0,0q�6D   $	��Top=�6Y   $	��110��6q   $��25��6}   6�   �� 5   
   -   5        $ 
SelectYear��5      $
��Left=�6(   $��158,106,0,0q�6C   $
��Wrap=�6X   $ ��Избери година:��6l   $	��Top=�6�   $��66��6�   $��20��6�   �� 5   
   -   5        $ fact2019_2020��5      $
��Left=�6+   $	��174��6F   $��
56,182,0,0q�6S   $
��Wrap=�6g   $	��Top=�6|   $	��186��6�   ���	#FFC60000���	#FFF8F8F86�   �� 5   
   -   5        $ badFactYear��5      $
��Left=�6)   $	��174��6D   $��267,182,0,0q�6Q   $
��Wrap=�6f   $	��Top=�6{   $	��186��6�   ���	#FFC60000���	#FFF8F8F86�   �� 5   
   -   5         ��Name$ getFactsButton��5      $��Сравни��6)   $
��Left=�6:   $��151,146,0,0q�6U   $	��Top=�6j   $��91��6�   6�   �� 5   
   -   5        $ addinfo��5      $��Добави нов��6"   $
��Left=�67   $��515,182,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -	   5        $ remove2019_2020fact��5      $��Изтрий��6.   $
��Left=�6?   $��515,207,0,0q�6Z   $	��Top=�6o   $��75��6�   6�   �� 5   
   -
   5         ��Name$ label2019_2020��5      $��	2019-2020��6(   $
��Left=�6<   $��
56,160,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $ 	labelYear��5      $��Избери година��6#   $
��Left=�6;   $��267,160,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $ reset2019_2020button��5      $��Обнови��6/   $
��Left=�6@   $��
55,361,0,0q�6[   $	��Top=�6o   $��50��6�   6�   �� 5   
   -   5        $ next2019_2020button��5      $��Следващ��6.   $
��Left=�6@   $��105,361,0,0q�6[   $	��Top=�6p   $��55��6�   6�   �� 5   
   -   5        $ nextFactButton��5      $��Следващ��6)   $
��Left=�6;   $��316,361,0,0q�6V   $	��Top=�6k   $��55��6�   6�   �� 5   
   -   5        $ resetFactButton��5      $��Обнови��6*   $
��Left=�6;   $��266,361,0,0q�6V   $	��Top=�6k   $��50��6�   6�   5      5      