PGDMP  .    .                |         
   CoffeSharp    16.2    16.2                 0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    59013 
   CoffeSharp    DATABASE     �   CREATE DATABASE "CoffeSharp" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "CoffeSharp";
                postgres    false            �            1259    59014    admin    TABLE     �   CREATE TABLE public.admin (
    id_admin integer NOT NULL,
    nama character varying(100) NOT NULL,
    username_admin character varying(100) NOT NULL,
    password_admin character varying(100) NOT NULL
);
    DROP TABLE public.admin;
       public         heap    postgres    false            �            1259    59068    detail_transaksi    TABLE     �   CREATE TABLE public.detail_transaksi (
    id_detail_transaksi integer NOT NULL,
    id_transaksi integer NOT NULL,
    id_produk integer NOT NULL,
    jumlah_produk integer NOT NULL,
    harga numeric(10,0) NOT NULL
);
 $   DROP TABLE public.detail_transaksi;
       public         heap    postgres    false            �            1259    59021    kategori    TABLE     v   CREATE TABLE public.kategori (
    id_kategori integer NOT NULL,
    nama_kategori character varying(100) NOT NULL
);
    DROP TABLE public.kategori;
       public         heap    postgres    false            �            1259    59038    metode    TABLE     h   CREATE TABLE public.metode (
    id_metode integer NOT NULL,
    nama character varying(50) NOT NULL
);
    DROP TABLE public.metode;
       public         heap    postgres    false            �            1259    59043 
   pembayaran    TABLE     �   CREATE TABLE public.pembayaran (
    id_pembayaran integer NOT NULL,
    jumlah_pembayaran numeric(10,0) NOT NULL,
    id_metode integer NOT NULL
);
    DROP TABLE public.pembayaran;
       public         heap    postgres    false            �            1259    59026    produk    TABLE     �   CREATE TABLE public.produk (
    id_produk integer NOT NULL,
    nama_produk character varying(100) NOT NULL,
    kategori_id integer NOT NULL,
    harga numeric(10,0) NOT NULL,
    stok integer NOT NULL,
    gambar_produk bytea
);
    DROP TABLE public.produk;
       public         heap    postgres    false            �            1259    59053 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    id_transaksi integer NOT NULL,
    tanggal_transaksi date NOT NULL,
    id_admin integer NOT NULL,
    total_harga numeric(10,0) NOT NULL,
    id_pembayaran integer NOT NULL
);
    DROP TABLE public.transaksi;
       public         heap    postgres    false                      0    59014    admin 
   TABLE DATA           O   COPY public.admin (id_admin, nama, username_admin, password_admin) FROM stdin;
    public          postgres    false    215   �&                 0    59068    detail_transaksi 
   TABLE DATA           n   COPY public.detail_transaksi (id_detail_transaksi, id_transaksi, id_produk, jumlah_produk, harga) FROM stdin;
    public          postgres    false    221   �'                 0    59021    kategori 
   TABLE DATA           >   COPY public.kategori (id_kategori, nama_kategori) FROM stdin;
    public          postgres    false    216   �'                 0    59038    metode 
   TABLE DATA           1   COPY public.metode (id_metode, nama) FROM stdin;
    public          postgres    false    218   �'                 0    59043 
   pembayaran 
   TABLE DATA           Q   COPY public.pembayaran (id_pembayaran, jumlah_pembayaran, id_metode) FROM stdin;
    public          postgres    false    219   !(                 0    59026    produk 
   TABLE DATA           a   COPY public.produk (id_produk, nama_produk, kategori_id, harga, stok, gambar_produk) FROM stdin;
    public          postgres    false    217   >(                 0    59053 	   transaksi 
   TABLE DATA           j   COPY public.transaksi (id_transaksi, tanggal_transaksi, id_admin, total_harga, id_pembayaran) FROM stdin;
    public          postgres    false    220   !�       h           2606    59018    admin admin_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id_admin);
 :   ALTER TABLE ONLY public.admin DROP CONSTRAINT admin_pkey;
       public            postgres    false    215            j           2606    59020    admin admin_username_admin_key 
   CONSTRAINT     c   ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_username_admin_key UNIQUE (username_admin);
 H   ALTER TABLE ONLY public.admin DROP CONSTRAINT admin_username_admin_key;
       public            postgres    false    215            v           2606    59072 &   detail_transaksi detail_transaksi_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi);
 P   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_pkey;
       public            postgres    false    221            l           2606    59025    kategori kategori_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (id_kategori);
 @   ALTER TABLE ONLY public.kategori DROP CONSTRAINT kategori_pkey;
       public            postgres    false    216            p           2606    59042    metode metode_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.metode
    ADD CONSTRAINT metode_pkey PRIMARY KEY (id_metode);
 <   ALTER TABLE ONLY public.metode DROP CONSTRAINT metode_pkey;
       public            postgres    false    218            r           2606    59047    pembayaran pembayaran_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.pembayaran
    ADD CONSTRAINT pembayaran_pkey PRIMARY KEY (id_pembayaran);
 D   ALTER TABLE ONLY public.pembayaran DROP CONSTRAINT pembayaran_pkey;
       public            postgres    false    219            n           2606    59032    produk produk_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.produk
    ADD CONSTRAINT produk_pkey PRIMARY KEY (id_produk);
 <   ALTER TABLE ONLY public.produk DROP CONSTRAINT produk_pkey;
       public            postgres    false    217            t           2606    59057    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public            postgres    false    220            {           2606    59078 0   detail_transaksi detail_transaksi_id_produk_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_produk_fkey FOREIGN KEY (id_produk) REFERENCES public.produk(id_produk);
 Z   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_produk_fkey;
       public          postgres    false    217    221    4718            |           2606    59073 3   detail_transaksi detail_transaksi_id_transaksi_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_transaksi_fkey FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi);
 ]   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_transaksi_fkey;
       public          postgres    false    4724    220    221            x           2606    59048 $   pembayaran pembayaran_id_metode_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pembayaran
    ADD CONSTRAINT pembayaran_id_metode_fkey FOREIGN KEY (id_metode) REFERENCES public.metode(id_metode) ON DELETE CASCADE;
 N   ALTER TABLE ONLY public.pembayaran DROP CONSTRAINT pembayaran_id_metode_fkey;
       public          postgres    false    218    4720    219            w           2606    59033    produk produk_kategori_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.produk
    ADD CONSTRAINT produk_kategori_id_fkey FOREIGN KEY (kategori_id) REFERENCES public.kategori(id_kategori) ON DELETE CASCADE;
 H   ALTER TABLE ONLY public.produk DROP CONSTRAINT produk_kategori_id_fkey;
       public          postgres    false    217    216    4716            y           2606    59058 !   transaksi transaksi_id_admin_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_id_admin_fkey FOREIGN KEY (id_admin) REFERENCES public.admin(id_admin);
 K   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_id_admin_fkey;
       public          postgres    false    215    4712    220            z           2606    59063 &   transaksi transaksi_id_pembayaran_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_id_pembayaran_fkey FOREIGN KEY (id_pembayaran) REFERENCES public.pembayaran(id_pembayaran);
 P   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_id_pembayaran_fkey;
       public          postgres    false    220    219    4722               �   x��1nC1Cg�9A!Y�-��t�"[��������B� HL�����]/o����G����  b%�%H�BG��h-uN^Jh^���e�-dQ�%���8����V��(��2��;K��8�(�bPD`(tC\Z��Z�:eJ��z�~_zI��$S'q�,�Ȫ8q�="�4�(�Wl֌jE.}�����/��H�            x������ � �            x�3���/��2�t��N�I,����� D)�            x�3�)�K��2������� 5_r            x������ � �            x���ۮn�v�����#�}!���(!�H"!����_�A�� �V�k�Zs��Z���������w����e�����?b~������{m�I;}�zz�O~���RM)���L���>���o�g��/�RH+�c�z�qf	O������������wX�Z�>�?�>;���W�ޫ���R�?G�9���|����7��;��F���G��y��Io�/����
��|�;��������Xk��T`J��o|�xOs�G\{̓K}}5�oζ�Z9�����s�����g{��?�w�7���>{��c�_����i}��˷���;i��ىg��v)'�����R��vۋ�n��5[��*�S������ոb�#�1x��_�nm���e>���ki�b}�v���Y�Ӿ�Ě����v�)�-�Qz鹧�����2�q�I���O|JIc�в��7|@֝��<g�B��l���;��UG����:�J�C-�����c~zn��8�~6O�6�g&�,��u�/S������u�R�.{���<Gs9�� ��01�����3b��b�1�5xŗR�}����SO��gf-�v拳�^^���;;�qΛc���7����5�F�u�f�Z���'�XKO�9!�Ѿ���yW�Xx}�����[ͬ�����R1�US	��P��BIٯ{��)�r�S��o�x�SX��I���]ٱ�_����yTV�o�r}����	��!}ļ6��c��˟�G!
��wo|�sΘkݡ<��Xـ)��'���:'_y���sn_����tl�L����~��w�@��-6ԧ�b�	k]5�f���	,7>���5�&�M�"��u<��8������S�s�.{��l!|��26��V�+�k�q�	��O���o?D�b4������eg'��6{�LOzFa�czٴ��J���c��/��_b�����'[��.��]q�V�dO��%���ȐX}bЬđ�W~��G�#.�'-�Ɨ%�� s"0��7	>*��#.J��{���N���-ׁx_�a�߇���	����r����ce^�)�g��؈9+1W]/�DX!�a��<r=��+8�׈���Ŷew���A�S^)K���x`�<��Ml����bw�j�P�z��e��$�>3�'V=}t��ML����Y�×���Uf_e6�����Q���c��$��kls�{{���0�R�z%"�~���sz�#lu%����"B��?�����tj�u	��dkނ�4��G������~��J�ι�;�V��[]����H-��NO����0���[����	~<�o�h��n�5H~)a��gV�����ƾW�o�e����5+�a�b�'_���Ɠb�/Y����Dֈ�`�o������D.|1DL�g��g]3�0Ȇ8�؆�𮗏x'Y�U�!1�H�2~o����f�7�j����������<Bꮙ0�G�l�-��\�'�4�x��>Ri���Z;�x&ϲF>ħQ;ނ�w�t�s�v�<m���0�M79���������ӗ 7ag�'Ix^�����L�YEtF.~�[�n"��p����^�85��gn�r`���#_�O���p��zI����C~']&�'u�ě�Qy�S$ט7&C&@փ��n"a�8��}��D<s����< 7���M|��H/Oi�����F�|��mc�K�U�i�F��x1��� ��=,����Kr)�@��"m�p�&t����N�H��2��q�@���Ƙ��hY���&�[,ݳ�W�:��x��6>�̮���#�xp�������WA�%���kYDFK���(P�"��#��|]����I}�r^�;IRJ/��V��#ǀDHM�)��ˤP�^�ViFė�NS2����+�8�x�U����z[���� ~ɗ��>=�K�B�;���T�*H�h<O���g_�@��Mߠ6v�-쳲�ŵ�BN⧓��H��������[���hf�d�����m�� ���N����#'3��&H����PF=X(������D��I7�yƗ��F�D'߈?�|�û�� �A�j�vXhl���s`�}����|2VN��j���7O_�/¯��K����F�<`��aM1d\�ڗ ;�wD�}a�^ph6���Y'r�J<\ �y�l-�̖�`�}&_�����\�� �xK�#��fx�������q$��&>�����8�#�ccAnn��L#�q�:-`3n��,�U1�%X�!�``���܌��m�@�C��C�A�Ș��r �dD2V1�T�$��[���C��(������?�P_�⸢ ��|���z� P�,L̼�V�A��mB5�	 ƺ�Ґ��_O��:��%	�a~�Q8%q�I�NbAbB�e~P`Ӗ�6"1l�u��a @G���Mx��
 �h��h��P�`� �J:��yF � �D�b�RY�x`6Mf�y;V�,x[������ ��鍐��f"A���i�y�q���c�����nV���!������/y�]�~��]��=`#����
���1y�
�>�$Dg��:��A	dmF�8	^�O��/>�5T�Z>?P�c��齌�&y	�Y������������;���H,).Y!S�/��`?���)��c
$z0y����"��Ώ��6+̝�9B��Q/%���k)�$:��2�-v�ջ)�t����9yr�	�����(@{˞�%���lq���7'#>���d���Ml�(AF[�L������I��E<�w�!o���F䯓�#|�����\d^�=�͜��tcR��h�O.x
���k�ψJ���q �`����� � �<���d畸E\yU�5�(U�<�8X��%��`�=���H�G��?f	�X������Z��v9_��!񡸫_�`�����p
?�����̩AY��z��AL����<��?�X����N�r��#��8�?���2o���� G�?����0�~"�XW%�0x�XK�/	��0����P�\��{x�=�w���h�W,�3��ՀD�"�����EH<��3	�����Ԁ��y�d���@堡n8�KNF�&J����xȇl5�8?e�F`Ы:�K
�cn�2v�����\<���<���X�ݬ�f��$��+��)ʒ(��} n�VL����_�U��dR�jH��`6jo�i7��L����h�^�ǈ
+l����X�*�,A��v�#)�d~e����Kpȋ�?ڞ0�`��m��F~�g�bX��p���Z%KQbǊ��0�9�y�ޒ_��`>ބ`O��A��Ft�c$�6�1��MI�\})�#Fb�At����`������`%�R�KB$��'��+�&��Bп�ˣ���}x�� �\炶xf���� �|<��6�&U+�gX�K�� ���=��#�[t"`uzŪJM-�������)1�l6��M�z�N�Գ�l�����@91
��
��|��&G��#���7X��>�BuX(�%��ΐ�`1o��x�������{x �f\nŚ�J��Fdh(S���	z?�$@ą'���s��Q���aMY��OD�t��#G�p�����"*8�3FX��Kd1�K��>����`:�'IT� 4�r�#�`�D8pf��$��a)�.�8{��x,C�>J^�h� ���~�H �e�ҭAq�Q��L̂
��xl��jk$p�qF���#����K��9H�,�����'�2_" &�q�~���/{����J86�	$b3LX�}p��ul|�@d��ڰ�����< ;�u.L �;��,�ҁ�,� C$!��١E����~���S<�����SZ;2�`��jn'f.�K�S�W�5�o�8���S��ļY�А��?[���'�i����    ��F�ˠ��c0��JĄ�`(�D~?����7����<�V8�L��.������o��nƷA��
#���9�$�,Ao�Zg�M�N���'��wVŷ������ѳ�hj�Ҁ�:��BZD�Eޙ�WVª���,&L�ƲI'��	Ed,Җ0��Y�Z>Q0��e�M�K� ��o#7b
�s<S��;���/��� ظ� �.�)���mXZ#���-�I� ��~��ʝ̖�0���K�|jy�B\#:�o���c'd�<�������zǅ�' +�)���_c�O>�&P��˕�>68#6�N����G'�|�%�x� ��J����JZ��\�EV.��I��'�xB]�Ӄ�CGb�����]pJ��Z2n�9d8�?"��g}��b�S��M�'Ց�A�0�	���:م�1"_� �L�!��r�xTv>��5�� �ޗ�X?\�}�C��Ȼ�Vyxm�2o\���َĮ����A�/����������<�|�H��}K�����f�Л� �z��	s�az�����V�\a���d���'��Y��w�b�cԎ��S��	&���EM�If�?D���"Qc,�M��G��H1�z�PU�k�=�9�'�"_��΄��\p�P�L" ��������D���Z-,H���N$]>!��@������b����.e���@a�#�b���A�6.77� �-�J1p>�"�|�@P�E����⸿e�$ �&`��Xab0p[r3т�ޖ��D nP��K�Q�� LC�fh[g��$�"?8�C�� d@/@(���d�q�O߭�Q�7��Dx	H+8��ʼ�����N��Ճ�Q��Ǐ�����&��Q�U��0�͕�M��d�8&������|�	>Z��=�S6���6� �-b�?;�$�p�nn Q�7�z\�@Z��]��.s ��y_b [�ӄ��fx��b*������ <����������A"dR����R�Kd;Ã�k`��VͶ0���@@Jb/�vN:e9[� ���t{6k��������[<�E�U��.	�,PH����z�s;���>@]��o��Y_⏉����X(�$ `g[,Ҷg!���h$fr5�v�2�33����<d�jEGv��x
�˰:ÛbE���4��2�_�P�-r��3�a\ 3���x�m�d/_��"�x2v��!��w�9
! [_>O��[��W��Ӎ�Pv'[x�Qz+�L`����_Y��	N;@F,�aH}��E\�@�r�,���=|8�_����{`4�B&9/�m�����-e�8X�_�@ "d�dBlo�0n���'1�}���A. S� ���Y��h��'��"ӻ�=��S��aωx�$+� ��2W(VM^a�q���������5����%�5����[�:!ҋ�B�r��vuL�'���3Qj�ځl�{��p[�G�4>��@{~���i}��v6͢d�'��s%���X�Ab�Y8-���\)2����N"=��csBr�5��[��Ų�Z��R���D8~�P�w���C����{Y�� ��oG�;�h�����5[-R�;(�Mʭ7�����En�HuC� k4�Qc+�4 ���}<����wh��:>P/�ڄ����xa�Tn�*ų�L�Y��+�^sc�c!Cx:[<��W�i� ����Z7Y-��AA�MqE��17y2�\*n;��9M�m� |6���@i`X#���N:d|</���A�A�q�*lZf�g�����aᚐOt� �6�n0B��i∄6����V�-f/8k���
�¶���x���Z����α/�Ȟ.�`�l�=z5���؝�Z7�o��LK��{x��JFNH
�����ٿu�sj��}�(�,�M)=ﶵK~�A)����AT��B�ak8�PzF�W��d�����G�,NZL�d���d���@E��h���&o���'�W�o\:<��LT�Cw�6��������ª��~��}|͊#��e�lW�|�Չ�N�g���4��f�����&O����ٻ}D�	�IfK�X�y,r�,+����(OS������1�l ��C?KČ�(c(�?�C��gퟥ�jN����� _��X&�z����$�<�<D#�6��u�u��q��Z���ar�
I��t���ͻ�����6�/O�'<�4�W<��o ��<�����ވ�X+�����U^�:��ZL����"o��|�� ҹ���G�N��z|�9�i�2-�@B���8��S	��xy ^8��ɧd
�K�)�[�2��c<�
%j~L���pŧXuz,���ROh&�l�G��Ǎo/K�������n���
������|2,	Ӯ|n䧀ڊs��iltI�|�M9�.Ж�������ح��!(�E��[n��}��r��c�K���p��c-�D�<fht�9ppbÒaWY�X6�Il�����4����`�����+����;�����5;&�*¯���L������O$��D�t���e&�],%�6Iv���Jc{d�%-ZX^|+[� �v�*	�H*�r��l`��eR��U�u`��o�Aֶ-Gq�ps�'z���$$¸	��������k��6�x�M�	�X-ď�6]k|�����uю�&�����	����\��܊pc��.�|�]��,x�I6ݓ�1�����/"�!�g~l�m�%�
و�����:/H|e��n�w(<����������Y�ulZ�D0��xAr��}h_y�"�4�����=a�y��%�`$�~O�j�����@7P�2��y$����$�%��z��J4��]q����e6;-O;���ҁ����`@�}�||cM�a�f��%۽S�}h�9�Į���� ���<���{���H�[ lt;+�$��n����a�+�9�$q`ݳ�eQ
x� ջ��H��ֻ+	$e�Q��?�٫bC1��m�"0˧�,���ճP�.=@�G*LB{������E�GP������W�歲|@�g#.�板��'��f�g��O�-��A�#H���b2Q/ٻ���F�pYR�n�Zz����fr )�N�#X���QB��Bv_�6lXZ���ʻ�+���&$�ʞ��++��%�cB7��f'��5�\^����ҲA��[����@X	��~&k��-�HJ`�� �ڎR|�'?:�g�K�RH���4 }�Џq�9���6�X�̊��,P������U����tA7�*���+v۳m��t,�T�Q�f��b#k`R�j�d��J��,)�z����Yz�,	�|V�� �qB��|N��iSE4,�-  (M��2��l%�A�؎���x	�{�� ��>����mp@|���Vy��Ӓ��l�G�1Q���-ٳ:��;6+�N
_�����8��C��q�a��F�d7�ʱl���C�aGX!�j��j s{�YI�?{$��S�E���P�Sc�C
 ��af���4�n<��7��9�Bn�7����ر嬁Ż�B��(��#��l���!%ٳmlc{K���F
�KXl��?{}̛��M$�Ӗ��w�c��O�s%�ɏk�i��caY>�����e�9�u��{��˪9�	%sU���x�΂/�"��Z���A����a�͋ȗ�M�U[K�`zV�+6�ڼ������X��^��^�-��|�_Q7.��;�x�6=�_?؅u����t��WÑ=z&�#�����6?��uU+��]���~��c�/v��:"�ۃ���	���sZ��;�ğ�D)��_4�����[~X4�Bp�>=������Kؠ�$�GX��
~�G�3��B%������O��'���5Z܅�6����	Y&���\�w��J���D��r��߫ǘ�L]m�U�a��l�~:����8���X�    ve/Yf�,��fM�iЂHP}�!oNx�ÿŉ#�1O�~�_�uP�2�G�X��րP���n�P�ob���A$���ɠ}���l}4��8m���ҒX���2Z%���̱��x�d)�{�b�6�T��gL=�E�m�5Vq�bc���-���To��n�X�/ΨNu�r���me�QȂMpN�ѱ%r?d�L���Hd<0��َSHx2��#=� ��~.�;��X�g˞��鎗X#6�G��[�%؝���?i�N���I�ֽ�6쑷]:�S�sơ侩�BZ[vb�6�{Z��G��<"�*<��\��X�?�@�da=#t�zyK�[<b�A	�Q@������;|�>��RT{�c�s�1��zp��H#�@U����?��^�M���uFi8n��$r#���
�$*���=	�-uJ
�8!��r�un����pBg��cf<�ʿN��D�# �4��^�<����e~'�4��s/�8�����B3��VۄTG��	2Z���sP�W�^&^���Vf�
��D��}�)����>y֑s@<;ql&I��=��bv�Ie6��vТQk�{�j����hݳ�t��O%9���q�X�^����k3/��;�ih��N�$�4�B4�y��<&Q�,Hl���Vlu|/X9;��R8����♁�a ]�-��Rc� Á;@#<Mh�)�cu���e��Ҡ#88��W��r]ִ�:V��B��o��t����t�}�'H������D�zѣs�lO����d���w�۲k5�$�4k�l�zl�E���e�6(�&F�l�,��҂����^ญ��N�8�-�>08'�
�n�r#���#B{F�e���%�h�?��NfP�g�lN[9����5H��X��u�g��$JG0�9o�K���%!�|�8�u�5ɉ2�b.,^��x�$����*�YE�T��-�P�ͫ��"��ӃM'��3`;�,{#,��i�g����|���ݡ^IN�OB�=Ik����c����Y�a� ���x 	��sԖ|��(|kbA����t�4�}���w��O����?��?�����؞�{<���6�
*d�[lWI���n��V���*��Yd�|�e���^�|��Gz�������i7�x��S>�i0|�Y�w$�I�4�C��c1($pq��ȇ��f�l��<�]�R�%`0��G�L���Ύ,���k��	K��!��w�ٵYR!ؐ�K��BQ�06[B�tc�_��9��h��ftlN��@}8��p-�`B�+�� �Ȇ����Z�w(���hÔ�X����p�}<q��	���Y�"���ϭ���AY�#uئŲ9�Uō1�z����;�=.�sq���rXF�!}�2H�w.�L��쁳�x�غ~��
!8���9yH��X	/�X��l�Z ���?. �}��;�n%��3h�ܲ���!1�FG�>�n�ҝ���v����{P��P��v�CǱ��9�
{��-b8(�Z��u ���o6ǽ~c��l^�A�U�mzI��) �~�m��Su�:k�&�Es��� �rZ��+v �Ť�p�ᬀ;>ꁒ�����$�������`qq4������-xbǜ���>O�7 rcx ���~8#��&Ϛ�g��O���4���i$B��"�awf&!�5��w,¤��~żk�?y'�
q��ZR	e��iB!��:mɗ�?6�a�����i���G>M礲��D���]l�M�o�@�긝?��!]m��L�������
���o�2oÇ��3Iƶ�\�&�a�*+��/Is�fb��[�������XN�.tB���Q�ʅv��w�I����`a,��w��w�<��B�(��Nfs���_���T�\k�ƻ�i*y`�7~����`D&O����H�'�`Ư�E5Hj���?�jl��*��� �l �d�a'�'@�����ܲӘ4dYα8�1�Ϳ���.*(2��APi�-}~��� �x�9�� ��&�H:|&����'r�:ӌ�!X�+UG�ʇ���pJ�=6�=W	���z90�:�����ڒ�F!;����O���@�Js�+Y_Ű<)wrK#�O���ʡ�,�����7Ή3-��?�grA"y�������b�n"�v�f��o"���{�I_�s�,�ϟ~�t^�����(�Z(gs���!��4�>�w{&�6���U�5^�8ODr��p�i�3�x:�JxKZyv\=�b��3���7?nJh����b����K��r���[��;5�����v�<� ��������]���)��\��ѡķ����9�|
�ܣ=O1���/ *L41���
x�ö�}��_Q7����jh-<��.��E�b�n;������$83�tXng��X��S^�51���v�>v3�s�<�ٰz��$���Q�����h�#X���� �$&���m�N,سk�0�j�W����/<�ȑ����^�-�:����� >��6���+����$��z�$ N�@��x ��r2�4o8�+��焽�M��:�e�c��=�g#gxv��&'�m{�dA�\�
~���vɒ̚5V��H>1�piE|�ա;��g�پ�.��7��l��#dvm�&�ɁU��.Yn�u|=��/�RӜ���~_1����f ��E�)�~KJ�c8��뱋��Uq����$�c�Ϸ{�S��V�#�^������@�NV�80܌��� � 7wRy��˯L�혷�	�&)�E�n���	^��L�ф�$NC�it���l�!�q�so�)	��l }l��|y�#M�.02��OZ�#�����"��a+΢� Y?%N�$>@�!�'[�����$e:���P�l��,�o.�[f��f��3=��*[�x=���9!Y���sk�g}նã�N
S<�j1���n*��m�yS��@}�~@����v ���3@�%�b�/!���x �1c9&�;>��23Y=�XJe�j����D~ڱ�i���X���� ��<`1ORl(r���=G��M�tVc�ś�vDk|
8�n�E�I[���-L�P�bWei�sn���I��ll����Ŭ%>�?S���	+yեp$c8� ���ؒ�>g�N���DN�(��6M�dɓAAoK�?�`슌���_�k��Q%K� ]�r��;�؜#��R&���zu߉�M��"�7��&��.��7B{�坔����s�jK�#�H�,3����§n�^A�P��+��ZK �/c���Z���Fx�2I&${��G���$�����qH@�� ����=�Q[��
g;d�����]9��n�h�eӗ�����[�|�4<�{�_<j"O����JcA= ^E0B�D�cKz����R��a��;:S�{C�:��#p��ċ�%�H'qi;�<?}�M�8��9����5������6#v���a ��K�\�W5��n�O����$a�;=��eSI�-2��(2��}PP��a`'����GEI H�R�&�������gӯg:�fC�`.�Q���`.�E:���Z5G%�l��m���#{��?��m��Ȳ��IN�\"H��fOL�������h�R4�㿓'Y���8��3ԶY
���-��_�ae��APƖ���s������T�b��hX�ID�t�J2�F;���^����SQ��Yh�Z�ND�{�ؖ�b$�b�7g�<,�H�0�ц��m$"�8³W{�:���3�bư
�Tz���!Hx�Gnt����w)!=�KzY�0;����vu[II9&u��,�0����.�r��њ}��0�HP��}o��ATh��`��n]�fkqe��C������l�睁�/U�NMa��Cژ�n�j��c%[��2EliLf���@���*�A�6�|�sw���s�YV�±����6����ڊ�n���{�l�8�.Q�-��B.�<���<C"���p���c�ڏ
%    ����$���'k �����I�|��4�ۡ�q�)��R���y�n��Dȗ���a�lq��/ �E �5V�?���b}K"��z~�H? `�QȆ���E&�C};
�Z��&R	���� �j5���ʉ��=g�Iq;��@�h�D��(��Z�a��^όm#Y������`K--{$}������\�M݂_@E�Εjx�S3�zS}��b��|m��?��4e7<�!�v�������>�����w�a@�a�-�0\zgC��j)l2��;`#�ld,�(��m�'��=�i�TpT�6��Yc���m�#�*]��CS����m���21��y�J�^��VxA8�R�� �T�u|D,#W�'����
�w�󏟢��{rSa�~�
�����s�@��$G։��pK�<�)=��]>��C ���|����9�,��)��:ģ��R���be$�LB>>.�5�n�tP���&s��<8xw�O$�WN���q�G�T܎<�|���ӓ�����y:P"��
A��^��!+B�=�m�{V"sS��+��&3E�CY������� cb�oj
�e�9��ƛ���J�hS%`)��^��S�e/�m��{�1j�����4@�t�å4h=2W�"�JI"�6��+��9��F� �X���RQ@n�Y��|u��t�-�~@B������yU��[MV�p��J�@��q�q�-��<�Ld(�$�=x�>�+�}�������?�`h�Qy�~��6��8E+�4n(/���%[�����ڣ�͍���葆�PQ�?� �X�tl{��.Og�nD�n:���r� �
x57���`@W�e�]���/�=U�й�v���Q�����9�j�#?�����B���z���/ �$�^ E"�P����".�>�!����9��T���x�Bv CGr�
��rr�~��Dj��4�$���`�?�7��	�G��4����<A���.L,+���5S?�)��v�;	��o{϶�6�U�e\�Y�gA�VS�M��l�K�je8,ţ����rQ~h�U\2N����-[*�W�Y�Y�H����͟��,~�}�B"�M �t�] �V������Ɏؼ�ʜ 8�ӽL��&.�J²4��a�����̩�@�G��N�b�Q��SC��{�n���|M�o|p~��c��r��Ҷ9Y2�۫L��$),G�(PK�L���vs:5���o{�0-���ڻM��qŪF��w���`��n.�H�[`�; O�r ���B쀨ʙ.%��z(l���Zl$��qǶ�6ڧp�rr�1�"�}y0D2�Ld��U��F�eM~i�4��m�sD��^2M�� -�^�-V qV �J�"��ˉ�~�FT|���2��e�ߣL�� �����/ۀ�RIRKt�3݁M��w��v|[���㢩,x6�X���{�5���8�O~XS`J�JB��[��T"��]�^�Q�UK-Dy����zHU�� �p<��:z��9
6�0y���mY7��U�[U->�h(jM���cmT���\�����FY�g	��v%[�4<E��9��i�HQ���~3Mė��Z��T7 ���j51�J.�g��j6vl�}��������fG��c����<ʊRG�P�8O��>�6���U黰�`��<���Hx�Mc�WD=����!�Y���V$/l���|���*��x3�Jq��/��UU��X��\{S�k��;9�d����֚WA����k������lg����n�/�,Wfk�e�C��|�;և?�ZQ���e�{����ʝ�%���#������:��~���١��w2f�~VZ�Zc��y��ԝ�#Y-��BU��������ˎX�����	ڷ�=sW�i8|土��̎�.��,��b'�߭��$-����r'���[u埮D;_dC'��n���C��_�2;)Rw=m��R]�����٣��b�z��c�Ҫ&��gز�Q����\���6�!߀?��g\Iץ�Q���\�_�vx��2E~�����s�ښs��7Q���|�=�_�E�
������Ж�t�&���g�Ab������m���n�r���0�\�U���.�q����/�ܲ �xT�x��~�_�P!T_��p�\|D�,ѭO�.����K�����H
�K����;Y����r0+s���ٰ��b}�l�*����
��̝��W��8�� ���t�F >` �]��߀��=�w0��^@�z����\��i'ڴ�&��1��<m@�x����Q�]ͪ�޻����H�n�̭v�1ؙ���gx��0�^���	ġ���^�F_2&��7k+�DJQͯZf����-�D	��.Cho�Hi
���R���X,�"x"�)K��֓�k@��� =>�X�s�n{kŠ�]}f���a���*Ke��������3�nOꉅ�;�������j+[���\��ʚ(�a��W��Q����㡔:��X����-v)(���*����'��",g�u��o���$�g3y����1<�Z	�Dc�G�����������-�$O�.�/�R��(��Oo@�[fy6I?�������C��������+��w��D�����M�Ad��I�wg��%��V1����xAr�� bN��8ˤ�"6�sH��ĳw*��_��O��":.��"�㮌#+�;|8�J�f�Q5/O~d�~>Y�]{�m΋���*�nU���m.YQ9'�+16U\uվ���	�TE~��7�<=o�ޔ�����ٯK��;&��,.�F����O��rD����t����z�f:���&��÷@O:��T�*'�3֔��"ARU^��-�N�:���uB����ļ�ۼ�k{uіz�����4^OIÒQ껬�,*�Cڻh��C��<����fu�����J|��/����{�k�ܧ8_����cav�(U�Uĕ���RuREP�J��:�����6�1�F JqpGl\�R�\D�h')��{��
�n{L��[Q=��Ņ�Ӫ�]��,�/�!6��{��2Ϥ��,	�k�to%_�5�������N N�JWݖ �Z6�+G �Iٮ.�vR�<ށ���}�@$O[�Hl�ƕhr���+x{�v���VAW�r���$����S���(W`� lG�I;��&�!�r|�)r�43��)E�Î�����+d<�!2|ָE�� !�h�?Vـ�[vvڣ�o:ed�%|B�`eW�\O��ת'���t�4	����Y��xM�����ŦR������޴o��ϱ7,8jM*S�y���:���G�j2�X
I�5��^�U���.������^��C9Q���k/���LEb�rw�f؜��ބ�.a���A���4hF��CgR�ΎLR'KԮ*�#��b����ΧU=�rm��p�����Wl��QRQ���)n�{ەT�tv���ߵߦpr��#ɱ9x<!�ޮ98�xm���cOT��BJ	펪n�c�'��n|���ѯ7�8���=HW���0;��SV�(��z���>���$�Sk�a���/<����H�u�6{mV����L�Yӻ���'�xiT%x�ɺ�K�}�9�kO�'�dg�=�&p�l���)�`���`]k�:���	bh?�C�*ƃ�T6�Z�Z��}�*B��5J��\�Mt�]�UG�y��=����V}�Rj��!&�8���I�BN �?�\�s�>�'� ��A/R��g���ؑ4��Asp�Ίx���.XPU���@ƞ�^L�1\�KUa��X��,w���5�lfm�V_a��XvI��>��zUaE���l �
�#HGe����
�?���OP��qJ�_#"�z&0	~%��`2�@�Y��. �XI���rtu��K�i�t���g�I��d�m����6.�P�ͯ��u��U&Y�s}���:�&]���|;�we+��+>�D�9G�$���<�{~B/��0O͇��U!���,�Т ���l�#U�s6�=V�
�����ǰ    Tog�^�i�f��m[�v.ߋD~C�����n�7�P��o�;�#Uۖ�'�!'ؔ�����l#���ǫ]��zOr�b*{x�m�����l{��q$����O�i�������,�Nzn��6���[�s���8r�������������/�c����/����G�:��������OaNIտ��	�.����+m��ԥX���#�x���-$��I���J`�opiG��;��N�X��U ����|��E�� ��J���e��7����׸��6�}N�;Y�B���w8�!u��y�kTP����8U��/�����?�����f�/�v�w,��T��$�,����4�/��C&�r�ڎ�7���N��Ϯݻ����Q0ϭ�N�ݙ�>���������-�<�aú����p�P��vG�8�n��=����,�īK�&DE��nu��{���9W<RQ���`��/.�����[q����q������]�Y#J�|�DP�o��W��8�������o��*(��ڕ����J% ���I���!�[N�۲�@*敧#�v[�D�.�a��q�+;��]ۃi8���{*��5 �K����%��T��N?Y/�|t�/��jUu o�u��+��|�:޺��k6$��/9|�q�TM��K�5;��Z�F�#?�l���'�V���a_\;�e�	?��|��Q��q{/\���9�
�-���2*�C����wۭ��|ng�Uo��h�[�b5�V���LE�B���񰦦4(���H;�`s5�)��V����v��x�N�������Q���c -{�p�F	^����*�s3������������ʊ�(��JS��e����L��T�\����/q���M=˫�F{`�woU��l���R:�ٔ�XW�M����`w\m8Ӣ�U{�2y���qy���+cq�E�,{��2�6�_�3?] �Q�$;���c���&��|vQ��9kABBj,H@�؍��k~�V�@�Lo�����g��k�c ~�;煆W%����ٶ���Rè�%�^�Z/�Ո�\~tVs��:�3k��'��AXWy���}��QS�;B7��S?1{9*�Ƕ�	~Q�	��:H�%��3ޤ���o>����r�љ+�]�#W�))���\6�]��*p H�4_�Q�oy'�zp0a��(����3%�@�$�k�=��k�Ӵ���Ou&���˳��u<,�\���ge�=W��y��_�7����+�^{S���	b^i�Tﻘ�3��¥A�޲��{p�
�<(�H����e�6	�у�k�ê���S8��w}�$�fϽ=�`kX>L7޼]���pu.T��_ ;�?� ԑ��w97oeq��aYuQP����˂
=�u�39��n���A�����3�}��Z�;���y�'����&�#[��U���}�o���^���I�Nu�U����y�ei�$���S�}�ˆ[�8���[�ݔ�wk�Э{+��<ɳ��'��$/�b9��G� tp����u�Q��ב ��W9f�:���z�Ô^��l�E�e
2�>���]=�p2l���'�
G$Aݚ�$�$~�r�����aVe��H�ep{P��Q����ޱ�h��^jArେ���;%3����J��%�C�Ѽ�qaj��b
 sN̉� �i��b�M��S�Qƨa���sWu�Yo:�z������I>|����	a�"�����rJ�?��x�oT=�����K1�[rW`�˶T����������^�D�Q@K���z�lzK1�8.��vbxYB8䋛�I��C��{٪��{��US
�����@�-x-�� > �Y������cp��3�KZ���y[F�@hz^F1n�?o����l\D��O5��wZ�Z��HjS*]�za�cr�����b�Feo���m�X3��Έw��T�YP� �P�ZW�$�Jא��P���$`
���r[��@�%m<d���oTDU=�|���ߢ70��oђT�B_y$�P�%�vPzp� 2�q�����$���_� �
Jx�qN�࠼�݃�ϫ��E�͛�>�$�����ьX��n�Kh��H�E���t8�0'�4����:�b[����&��W��ם&3�$�3��U��{�ؘՓ-L�߱~KΟ󋶒z� -Uw��*�~��<�U�~G�x�{]��C�1 �	Q��(M��t~ R��IU7�8�H/����_"8�\�T���[޺h��ﶵ��f�z�*�١I��\�AU{V�g����p4WyroL�ʄ塮$�vq�dkb��F���F��8�����@�mP�e�:<��/�M`�=�\7z�D�^yP/��N�;���
u)�+ 	֗H}�`E.b�BRX@��!���Ӹ�'z\h� 0Wc�����6�Н/�ѝ� �;��}��m�()p/�L_��0:��PK"�5�
�s���7ի$v(��^u��� ;@�T'a��\�n^�?!�;�C�m�`��@;붿"a��/gݽ�Aa�ؾ]0���6�<^�<�ס�bnV���=�Y-�� ��2(_%?Uj���f���Z�����0������K��
��5�o����K`xq��t��ږA��f�i	r�l|��Y�c,���b*O��=^�6�y*����G�n��V����b�����ʧ(����{x#�q/��W-W��X�c b)K�?8��R�Q�D0���v�D��׉8ʩ��Wy_9��
�U�u�5{
��CW���G�2O�h������`U~m�k;A��hi����K�ӷ�����g�%��@S�+۠,8��&����
��g�ڿr�T�_��0�C�dHi篆�݋2�X@a۹7W{�Mu��Q��`���za^�هe�6�{1��{l��d�软Ѫ�����=ϰ)	�xH���������a����eQ�w�*�T<���Z�ȼ��r9aV���R�.�{[�J�v
^��÷��^x	_{��06{6�m9��K�}$yi�'t�G�^�ٷ���`����W�ȷ5�?�O(�v�t�FW���L6/�	해=��별ʬ�����@*�T�Aْ~hw���~d1�m���Q��MujR���-8th�a��Ʒ=y2�����5���ՒLs�1�2/���ˋ�tEH���"m�� �ۚP�Џ!���(��C��jO �~u��-��T(�륊ʾ�,��A�R~��Ɔk�߼:��݂�z�������'~g�	�����Q��4�ذ��N�.�'4"��V�	�`ǌ�]�2���Ao���S{��3������ �g� �K�a_U2����WF.vo ��^�H��y��/�P�����s���oۋ�U1���'r|�c��z��x���W�<d�Y�7���;{�R�Y?ڔ�A�5{[�Ζ�m��Rp85[O�_Lp�ì�s�;_�w��^� (j��p����R��S>�"웸[0n��-m�9��ߪ�O��eo�5��*�bC���jqӝ
d�3=�=��Y4�^���cBua�:�ÿ���>�q�=��Y1�/�&Ӱ�����q*>�z�=xrH�Uw�	��	��H�Ҙ��'Hk^���<ޝǽͻ�3�z�*�d<��j�@�{+A���Z;�-�L���Y0	���UJ���� �s�E�xy4�h� ~������zo|'�Y]��SI ����P^\�y�2�S���ne�#�b����4p�U�#g�a-��!�RP��:�}AH[:f�+�T���ew�$��N�c�0�)��;��^Hrph>T��~F��W�|������1v�}��-��p�j��G����{��WS�j����?�
�z>��嘶���nS���؅׶>H��"���U�xg[����O5S���(Y��w���y}�ݵU��O9h2V"���<.��1z��7o{6�:�hO�r���:cr]�~�Ͻ��k�+�,k�R��z���
l�̭�%�76ДuB�Xvr�y�s��*㳔���~�������#����=5|?�I�  /�!    A����G$�����jW6�*��7���,E�q*Ҳ+C��n}Uѱ�1_y��a;�J��I��-�
ݯX���ֽA����1W
�%j��m��W��~��8���<R֥�(T ��l��k��"��;,
/1�[��b�H�Ħ�!M���	k��hC�z��Z�a�N�����vװ��l������Q�ϑ��EH�Y4�������m���?[}V�V�cF'�"�'��y��1sv�b:�_�)G�P��R���ٴb;�ٲTU[`j_<��_�����A@������-�7��s��`�������-�Y��+����f��vڂ	����r�����t��^3�V�w�6�}%���|�"�ӾGۤ�&�/��`���XjV�B��w�C�&��S�|Dt'����5��ˎ�[����3W�B*��yy��ڷY@��Z
���SB��\�j@
��*,����A�m<�;��V��{T��.��88���{L�96���͵xս*IvK'��7I{5��1�e�2yz�&!l�,y�v�����@Co���
h]S:Ě։��|i�W����;�mzY�"W^�`PV%�D���m=��NB���Rx!`�`ݶӫ���e ��򡊋���F��^�Xݵ�켗$+x��#�W/���Q�����t�#��ǰ�W���\�\ӕ	Ǭ��	����7ݞ3����[�
�'{�1 ���s��v�*�v\��F[�bK[q�ϻ������/%m��1v���*�y��,'A�f��{��z3NK/o�����~�[~��e9�=+w��˛
�`"�+*��I�Y0W��/�t���"I�Tc�V����D�ӛ�$�z!����T��d���I�����Lk:����l#�/�3��RҼ�kᯞ�]�s�SyN[�hb�Wp��W[�$'^0:-}�zM!6�A��5�X\�|Z��xct. ��4�����Ƭ��#��~�<zz�O�TO�/��m{F�fo\�K/���o�^(��1#*(���'�6ǔaB�aXS���$i�c�:��a�.��f����n[=yk̥��%U�^e�ݞ�zy�N���t`n{HHZ��3������L��F�� �lW���P����b�
¨�cı�E�ry8+�Q͊�AQ-�i���ΫG�'�<*�xƶ��Ib;p�*��T�ŏL���lGnK �:��=_�r����Y�����!�JL��x�m�M��T������^ �����KKY=h�WY=��@�:ُ�f2[^(��.�H�K���b�-��i��?���t�Z�U^�yq297���^� �?�Q���}�nB�j�^g`�Ћ�Ռu��7[Ѭis(7�����J���>8)ۗ,��m?U�n���I:�������g)Vh�i¾��6[���I5���X��L��S��˭��t��|-���Û���%X-y�B��>���^�Z(/�p�U;a��L�4+x�6u���6�˥��O�#��Q�>���Ɗ���j����l5g==��~��
�E�D�����
��Dv�(�!��;��x��WW�=٩������9��yV7糖���V�c���W�q��h^p��E�B�ք�`���ۻ���ŋZ�=�ڦ��^�jV��Z�L�0K����{矶��
U����RW�<���z�B�~��?��a=v�eݼүB�-��TB���pjTT�r�2z�[��O޽R�ϡ�쀙`_�{7��z;��/�E�PR}j���t���>S�϶�;\��;�6�İl�㪑�YLZ�:K΁�z:�D����Rv(; �w�|{���CU�S�[���&���N�7V�N��,P��5�<��!Xm�J�hye�^���z�zѭ�^5%H��=d6�%=޴qoW���<}]�5�@M��{���+^u1=��:@��d`�PET���K���
@څ��}������o��԰Ϋ�C<�W����匑��`9�H�����z�s�&{��牖���E���4�(�=D ð%D�}� w�c����6x*A�D�R�^�֌Wξ�W(ᵱ6ٕ{�UI�)�U	b^c��%;�����J�(|�E^�HY�P}d��c�C�d���NY�V9A��j����+��(ѫC��cp��O���i���r��q�V�+p�����ۊ�%�W��+�=�����%�$�D��a����z��X�cW`RX�&T����U�V�-�Y�
�gD@�����u�Y�L$T2�}�ڈ�lg�#.ە�;j<壵��P�&`u�S��x����}��o#T���V�S%�d�|�MꟜ��Nhޝ�=��X�W���R! � Êc����2^L�y(��n�z��ZohoV���z/M��	N Ch�Qq;T뵤Y���"V5(NX5��Kd��щwA:��������B�^��z/r��)�^��ϫ�o]�?$�~]��䣰����ϫ�@��{+��p�N��w�9�s����V�"m4����p�N:@�ڽ�ez�e���g��Q�@@gEoV�ұ{��~%`�!/X^ͫ�wKuˡ�u�QJݘ�!���{҇3�$[�OG��ZmI^彰��N�j���jΰ'�9��ⵌC9-J����c���h�4���Υ,�(ҽW�%Oƽ�ם���+*����&�Ԓ��X��3%O���uT�*�ͩ��yU�~�}/��|�?i�U:?;��p�lc���-��Y���H��%�^�*��<�*2��>�����{�-�7G��7�}
��P��[��=]E��b�7�x�)z���mOvNz���?��.��@"���Y����W.�%+V��ƽ�s/�G>���B4�
�{�Y!�':� p`�Sщ⍺Ot�د�v�H�MΦSBA���>��W�<���Q�_/e��9��= V�3~WD��r��>�襶�@��@�xt��ZT	�]��v�Y.�C=�kz댞r�����[���I�d��<{b�Z��y_�c������,�(�2۷!o����g*%�yO?��M�}&(���u<ñ�fGr�=xz<�]�=�*���m.�>|A^�7vP��W�I�S�Ra��{1lއEʳ��FR��zU��l��d��l� �G����q���͛��'�:�g9�����jvT�[UԾn;�(�\��Q�yS���S�3lǫ@��[���T�J{�=��t�����	���*b�L��d���4y�U���>_����-�H�f�\c������ۮ�LR,�k�a��e�Wܸl�����/�/���B��t����îʌ̌� B\$s����d5��I�I��;A���Ft�K{�\��H�<��|�^�h��o�s�-�7�v�Z>tCz�:_>�C�3��6�1���]��<�D�/Y;WgI|n�Dd&��Y��7��������)ې�9���'z��O��R�o�0慜���'5�Ƀ�b��Z���~��X��H���B�(�hZRv�+��`�Crc�6�F?�7�#�e�S���Rw$���M�w���f� ���-)f�4��676|�_�4����g����FyR���}��������S^��Z�|�2Dc��{�V��_���}��)'NĹ[&Ӷ�s��G��>���;�8?Լ=��m񧽻�N����`�ӹ�m�y<����^󟉩�v/�Xv:Lϧ=�M�"d�gOJ�c�)�J��xl'�/���ԣVWrկ|�︽���ͻ��g����L�PN6&��|T���r+�ADzw���Rk@&��A��F��B��2���ഡ�>D�~N�|� ���z�=�>�4�e֧v�)�?ty�/�M����Y�{��.eIĹ��?7����Ҝ1J�y�&̵��07#������D��������7����41�LmP�8����
2C���^[	،��5�ۮ�.杉�1�:ߕ��g�5$*l;�`���ŃVE�$Q]k ��q_ʿt���^k���5������0_X�7�7MϤ�>%�dH�_d㍚��gk�&ctӾ�w�L�<sI�@��2�z:�g�ج`���\�y_�    �f���K3y�		�VH
��}y�TG�xB�y8����[H&�)���)U�$���IO���E��aJ�q-Z���A��i�Fl�a�AҔ��>ݩ�g.���U�7���'e/g�_�Mx$���enn��Qjm�����r�H�^�d/iX�	n]i�m�s>�Zӆ?ɔ��	��"�;u��	3��ۣl�=J���\f=S��x߾�6��^�eA�7�6_H:/Ar�pvrG�Sƥ�cr��a)%�-9�Z:Y�|$<��&��f�ޱ**�f�@���~s�sɒg����,k�g������L�	�%Q\���6�f�g<����&$	���.��Id��[��U�h;�X���zs�Q&����O�2���;�$f�y=sJ�Q˅!��$��SN]�jTkV�S!�hn���Č��'IR�<(��8����Nk��V���P�9IKr[kh�F՘$�)���@qC�c�!_͂R��;;�뛚m�����g�0��o�������3%�`1���m!M����5��G����x��j�Bqc�X��r��ei�P�u��K�9��HT�I0��'f����a�[$QPw�(U<d}�׵��ďS�.z�H��I\b+fF�Gۉ+7S�2�_G��=yC�����FGP�`��xs2ǘȕX�z��},���sD����r��x5>:-M��[����(�0�_�4�q��|��y��vO
�b�,#��Z!
BKL�<���^(���#):h!5٭�h�j�(��RA�b���L���Β��]�W��7Yy&~O~r����'�o���j����͍�$��d�ߚ��=<�Qh�A�۪s}Z堤U����մ2�?�ڞ�c��ΰ��A9���7���f"U �%��p�xl�.�Mx$}:k���f/Ăt��k����8n0��乭t%�$���������^M��nI]t��\Iݒc\��A�D���O�\��A;ϒT���~��9���2��><��z��P��4{��!��gۡW��S���Skm�;��O�U�y���I����m>C����G&����\��.Xa8�Q
�)�1��c�[E�yx���M�6@
(}���*{�}�|H�~7<�z
��w�v��Ŗ�`�W�ɮ��䱐�J>��n������KdM<�'���?{^\~��pH�yfaھ:e3�\�6�?�q/>Ŭ���i0F|0c7���ڣ la�}�����c.�Oe�ғr���]s{��T5x�����j'R�N�P��/�S�T^�^b6��^R������x�A8!"�R~�ч��Uj%��(O�#�ΊPR["�S7Lێ�f=��"�%$nK>�����y�����'��V��)Ψs�͔P9���j���Hb*�8�]��m��.���v>�/�*�,5�h-_�i7��x�k.���Y��:�׷�ɹ��2�ʇS]�(�E�#��Rp��A�=�d	��u<!����(ȅE��1�~p8�o�����UZ��,��������bOpE�������A�I��(���#_�s��K#�9��{l�U=t��ܚf*��H�?��4J��ѱ�5�\+C����Q���N/[�f�
�R#݇k4��0���Q
�π���ү�9�|l�3"��ZO���\{k6��B�h%�JR� -���f���8�A��S5Oo���@3�AB̍����W�$a�ԡ�f���'�=�*<"���|-������i�n�����a#J�9�(r۬��O�R'��I㨂��yL���c��ӣ���/��|J������S�V��:=����b������	��@rĕ��ڼI����6�,��q9�����e/���j)��窗�,��ȩ�ش?\w~�� L�ӹp\@f[I��Ie(�_U���)�A�k;� c0O����R�*��������w������O���ͫ�����4ɚ|�鲭i[ઑ�q888��(x7��O!w}�Z�ِ�>D�Բ�]��'Cf{l@X���^����[r�KMyXE��z#%��K91S��I��<�0��b�4O���l�[=�G{ �oz�� ��$?�lK$j�`^�.�<�	�o.k�$vz�KB���"^VQC��|��w�L͵c��<�k����N�<�r9�)q���7����;x7���w�?X�o_q��������y��V��tX���d>��N�%���Zg��/��y,V���Tbvv[kSpk.U �-���<�Y
�K�KbJnD�n�8BpI�BA�x��]���8�����[΅�ĎƜ4?9A��]����W��g��5�� ������,��ǁ�[�@x����\����W0ref�X����� � M��8؝��Ī��ou-�/d�6:�b2h�l�'c��
���q��+�R��J���L���S�[M!�D������-a'�4�AF#*�$0���|�D������A7�J}!���8��%�5�/�C��ŭ��՝D��LI'cxX��Q���.�7�)��T}E�k�	��jq�Y��>+*�	ɶ�G�G���
r�E���т.|�w�Yړ�F��|�0�J	`�zǬ&���-�,6����&ސ|F�W;��UX 5F�&ĸ��Y*NtLy|�<M�RE�̷�   u&m�:��i�p�"��'�����5���;L�K�p%�O6$W��%�f�p)`�	B^��NK�k?ȥ��ɼ6��ˑ�r�Fa����5(mb�F{�2���g�t�ۏ�Dq�� }�s	�p�t�WV-�8��D$�g%�sN��t����������a�`��?;�)�Q�H.7�/�Fۍ ��p��s]����$�9y�L�H~╥̼���lfmZ��=�"R��L�E���$Sb�処���h�>����ǺWovD�YJ�}x��qOc�}d�� �����<fq;ɓ��B��i�?̨��g��;S��Nq�dJa30�8��l����x��O���'�<8���c��MD���繴&�E��Y�a¾��'Ѓ�~��"��~��N��
���N��M��߳�T�9��sZ_�9���V�$ZߖU�*n*g��(S-kq�>z�ٟm~�2',��JN�d���6�E�f���s��A�e��ț��x4�ns�%-u���ż����F�C�ɫR�YW�}h�
��%��ر��j�F�?(��d���TM��dò��ڧ_����i�&���EP��ksE�~��Uuc~��{�u�G�ݪ���W�~Z�X ��KR����ɁF����<M�\�~X6H-�?�F�� s����[=}�"5�ϵ`�C\899�uK~��Z~w9�'��������Ї�!X�Z���h_��tZ�cўM��ׂ*Hv{��d6��yY�v�m b�u"��L��S=x����6:^�0B�AD�q�f���)�� g@��3�-�o]��F��TJRK^���#���a_q���ӭ�ֽvg� �g��ދ��9_���^���;:��~�<K���y���4��㤡�����e���F@�贅��jI�_n�F�6) �(h;�[_���o5`�D�&�c�Fe�d=�(w.tj�Ķ ࣝ� sB��|C?Q��c$t����zu�FIHt�Ĥ �&H���Y$����p��J�Nr!;�Q�*0���cG!��g�ۭ��&����0'��K�`*�im���Xt&�7n~�\�Y�Yn���螴e��b����9��c|�cM�v4�V�퍈�9خe�QLU��j�J�Â���� ��\[.QmʿOm3	|�4�O0fSG@I_ٶ1kNP�\��)�Zr��-z~��dR0y݉{�I5�j2�j�z�Oy�8�?�=h�)�'G��~��;N���Kv4�C�]�~>�5I�� ��·�蛎Ӑ�b��5�� ����(BZ�٘�b�O��M�LnMQ@�n|O���:���0-�6|��y囬*ŪP��Abw^�%��aƙ}7M������<��5;%ޢ�$�[��yhqz�HfX�Z�����Qݒ����yɮɕI��<��ٲ�0    %��l�e�Sm@+C��6���ƙ�T:9�Xx=��R�K�-�RKL��K4^��YYY��ADw�g�.M�ȡ�� ��٥ȁ��:�J3kG+G�{t�Uj�[啨���ϓ�5y!�ޝ�|�!Y�3�룝=箳Eh�z�#�܆!�"�ob�T��J�[��2��H0�՛�<�!Î�Z;�b�� p�[��hզX/�_f#p0�w�D��{���@tՊ�
�`Ԡ�硦^]eK�@l3 0ŵ��x�	��K3�Mۗ��{�؂�z=�<�؉�/y��1�N��w���\�З��M^�r��3����/��]�ے؆&v��Ggd����i*5��.p"0���E��|p�&�Xd;�Ԕ(EyIey�(�N���3��*� q��X�;�X�iu/�
�Id4j�p�]�;�"@T�x��d�N��J$6&��&-kb#m}�go�����1f;�2� �c/v�t�n����!�4jX���>vv�s�~}W��_�%��3�s�Zh��c�>�!�����!�E�Fr����0��8��uc�M�%�r�[d�/�z������y
�"�=yqz�9�����MA���qƛڲ�i�����d��n,gh�ԀN(|;f��Kp:_�%����L������;8&G���l�~���Aڧ���w�����ۈi���$���Ț���������'��|�x瞱W#>Ut^v�~`&�g<V�<�Af9oKY:� m��\��[i�b*�tه�:�Du�B�/��������'��h�ܱn� 0W��9���A�!נ��b*�>�O	�l�^��/uK���N�o�L:P��
X��$l~фvja�~�3�Nb�~J�2+��RY����I��'ֲk���
�E�:^V�3 ��Րy�4y��P�\�)���/�i%XsML�m�b��Lei�]�㋶m���܁����?��p�M�Z�(�����x�=��S��˞w��ܦ��s%�S�ݩ��6JZ+T��)0�x$H��)�%>f!�.�#ڵ���&q� bgטW�උ
�7�%�'q]pi`f�T�С�w%�"[$î��N�gr�2�]���|Ri���&�۸rqI�����Dx ol�3�*&�n�7o~����VN'Fy	����w�IL��)��k�ϔ�~[g�*�S�@��,8r��7~�s��_p�ïu��!��GA�	�e)������u��IoA#�4����N]O�����>Q��N��	3�]!��nZȚ�- _�I	���t̙�n��`;�߱R�6��E(���B}Œq�
��h���]�mSs�%��ѝ���������3��cзϗʹ��3����)6:�P{�?Z�9_�$��7_�Ufw)�l��a���#џ7��b�x���æ���~D�}�X����_�7Y��4��o�S����G۵;��������q.�R�ř�c�)'Ӿ�`$p�S� ���Nu����L�� �C[b^�Rֶ��#�و$���a��vW�>�ד񟔍w
ȝ��]�]�n�ݕ���9ev%�0��smmm��F��k=r��e^��Sǲ5|�#@?͎_4<��i���1��ok "��w���k=���q��XFΊk�|���I�%�<�Nb�e��:���H����H�E��ݕ�c�qqi�%:�9���I��?o�r�9��]T���fzjoUҶ�J�~��h��0�;4N��-k�s�^�y�49_q��:8�X����E��J[B|��un�ߔ������w�����_�����XJ����"�����;�z�:e�;������n_��+sS��(�o��m�F~�N�4�N~L�� E&�2J��lgyP'��4j���9xc��D����S���e����,���m}kaD񿯕�q��K_�T�S�����4zH�R6�F��Ң��yt��&_�����R���������Hg��a�Jؿl����ؙ�-l
�T�ӝ�1%\":� ��]�<�X=`�Z�N:?J+�2�6���Ax����9y�l�?Z[
Z�G��v�"d��?��0��?����4v�[s���
�=xt�SZ�H���5�[����]��ؚx��殖��/>7�{i�af��DYZ ��S*��Y/$�'O�Z�/k�g!zI�x��K%{���Kly{A�%𷍃��ju�"�v�\\t�K��,�ڥ�<ň��Øˉ)q�}[��z�P�s�ɣ�3�\mb��\݀���FI��_
��ȅ�蹨�w�~K��.~�Rk�/�f"'N�{=�{��1��D�7�8���s�����U5��h_�M������.6�48Ӯ{�N����Gb��������`;֌dl��y�I��F+4O�R�|�C���$��:Ԁg�R��������7,uB'A�{�\�z��6/��&�A����6��xF񦿯�vv�������7��W^M�o:������˭������X�u�ed�d�Zv?����b�/|�}�M�sc"Dd�~�ka�#5�Ƹ�AN��i⿧̸�ȝ��FZn�����i���T�o�l�g|[n\罞�;�^ͩȉ�\Mi]��F��i6ox3#$���Q��;�S�`��p(�!�����;vk���kc��j�� ռƜҺ�x�9�95d yͦh?>� �ז;�;Y���d�X�c\4D�oΉ}86���η�7lk/]��z�^��nN(݌{���4��6�E����Fν�|Fa)[K�8H��R��6+��a�`��AO{P�ItN\󖒾n尼beb����ϫ8���:��V� ��J���=y�ÞȾ`�:�ͭ���I�B��C7ޤJ�����f_jAY$��EA�&�j�"���YMQ+XrX�L���I\Ӈ"�t��`��+��ۓ�U��V���L��td9���]V��Y}&U'*�>iD]�hj����<ã|8S
vMZ2��bz�u��������<W�6����ex).�������i��ʰ<P�l:���Ɵ��<�%�Ѷr�C���#�w��lz y�*�lR+�N�����D��lX���ޚ�u�h�}�$ˏ�A�Ҡ	t~r�6���oF��e5
�g9��of���v9�����I/J.l�d񜫔���z-�#[J(����{�Se!��]OY�,���m�Ӊ��#O�eͱ���%i�M��|�s�����a��s�N5ܴ�S�'	Zݹ�s��%f�Me2YmI�ۋ��F�ʟ�MnW8�����,o��Ww���Fr2�V_��5���=F�6�G�n� �8m]S+��G҃�;�#e��u")�Ю���3O�sqЦ������S���d��ZK�X�����)o�YqK�0��So�$Q04���ZL�V���Wo+��⻙>���mX�i�l	��3;��>�XSJr�Y��'w�QK�Nm�(��0�b�[>^� {��D���6Q~Y��z���V��{��{�������Y\��B�K��ʗ u"���Oi\�ZW ����؅�Ӫ��C�d�g�2�j�|�i#� ʑ�恚�����y6�Y���yf5�i����Ms�g����w�ב�s%L&���b.|��-%�&��B��T����Z�ܱI������'u~���4��K욭@[�O�*KZ&���s6&e��S���V�g��g�tj���g�#J�f��Q�]�;�c%B����f9�L�}6�̩��>#����)����'��3NIf�
�n�`��U�JKH�"oB��z����M�p[�z ��Z�k��=��sЂ5Y_��4��-�;�:`��닔�8pg�]��X��,Kf
�y�x�Aٶ�yn��z��ܒԗ*(�B��5�C[��J�zt/i}��r7��.N���>�W��r�!_�䭗�R>��|�D����O�����&�/�k�LW�;�<j��N9r��~+�˃�6��
� �ыx8�c���u8:a-7+�P3�(1�o�+�i�}�a��/�d)�`�Moy7V�s��r�	���gb�����Q8����3a�����\r28F��t�ya�U^=��$/ҝ@��e��wo?I��F`A��p    �.��a(��6����QC$zN&��ϟ��Z�9`�����Ӏ�GH�5^�}ۘ6���c
u��$����Կԣ�PN�u�w�Aͷ:y?�I��45Y�R���VF���a
�45�;K�H�y+�8��8Sꛙ�9䜈���J�JZ��w��z���\��Z.yw���[h��h�o��~��^������=_N��H��i˟T��W��2�OA������C�nM(�T���&yɽ`����/�=	�&���MٮN���N�8p(�$�x{Vl���)���gn\��#<N���VS�������72��<��DNn� W���#��NZ�����+��(�����$�흺�1�^N�ީ��1���`�:�B=?���Ŀ�pn�J>����� ��d��$WS�'��!<�����Ek[���r��I�#Al�����
�7�����Z�]�_�YҸ��bhp|�,�
�����f���X"Z�%��V��Ykz7k��_��1�8M���Q�՛%w����=���q1#
|�f�ɲFgm8[qz��K3��7�������y�0�-�c�d��dL��(ZO�T�ke�"�[C�GoX8,x)��nww�L��.��+A&,TS�P+ys߄���P�
�˲ݶU}Y��������D7U��LO��X��]QT�7�'0��l�t�C䁮9I�N 9�7��j��	��?�e���W[��ׯ��7�U�-a)�#O\o��l�o�>�u壶/!q���Oa�5:�V�wpK�L��;�K�д���T`ĩn?`�кX�Yy�1�zg�n�9ϯX��b�t$ 0t�xMؐs$��b-:��G��]o�
s�Z؟����N���۟�Y��]S���9��|�&P�'��̵rnMz���}�l���}@fZ��?�/	JU��ҥD���;?���{��)3D��9�҄.d�x��'��1�o��"Z�"���~�R˽�a�\��M.�(d�k#t�u55ld�O3/��I���KZ�7�Xm��<�����0/����a-�<9'���1�n�N.����j�0&t��Ɲ6�~Ր�� ���$�R/����<Œn�WnQ�lڸ��7��i�&��L��@��o#��|�N�����ڭ�2�R��3'� O�ǫ�y�`�!ٸ�˲�y}l��h�lM�[S��E�	h(6�����e`�9���S0Z��4�1x��B'.����O�ל��Kk{���h�5�{pߑ�SFK�����\���R�L6�|��`{��0_JVI&b�T6=��j� ����/�<�O�t���ya�O��c+��D���P?9�]L�k=�s����"O�pr;O��(e4,[�0Z66��0wN~JA���%�s�2{/�ǎ�6k����<p�1�B��vʹ�Yw��Jd��#��2�@gp\)I�[c�䈞�GϛOH�7I_�&A��r2�\�\�w[����I�7��`P/US�l������Y�;m6�^oYkt1����wOl+|k��%W's�N@�Z��	,'nϛ,;NK�]bГ��B�e]ž����Q#N4͡M{���h���CM��8N������<7B�e�{��o�ٚ��5V��������� ���/b����2���K��`�I>��>ݷ���Ym�Ԁ�I�?���������<���a����隭��;�Ü���ض�� u��iH�Ʉג;�k�c��(���B�>0Tυ��I�dO�(���(Ǫs~=؛��EƷ������M�8.ߞ�ۍL7�y�+Y<m�C��L�?���-$��̧W�J����p�����˟�ֱ��i�+W�2q�>#F�L��맂������M�X��4��z
X3��MHˇ��z��l��ԴŪ?��}D)��1Z.bϓ���+��Y`ԓ6�Z��R�!ܖ"(S&&��m��锟9kW�Z�79_���n&��53FNva�li�ul���Ա��v�Ww
L��Q.	xoJ���~������9?	�C��[/�dk�}>6΂;���|�M���������[����3-w��özw �bayJ�͖�����$Ε�l���ɒ�P��7��
� �}�G��7�D��%���s~K]�k��y0r��0� �7)%��:����f]Yu'�`F�I��=бw�x���b ؅o�R5���q����3�<<�09�,����M<r�r�v[����u5�Hԙ9�6�YMXډfׄc��T����L鄡e������r����*��%������W?�XB�׷�'&�7)�\,����Y�	P�d�L��d��t1�D��|��>�͆��U$���U����$A~:6 1��]^����25RG�j3n�˵�VR>��<�X˵)Ц���R��C�U�E�'a�(ޭ���|�b�������M*�Sܮ3������y��ݠ� .x�1p>���!�Nm�,%q�v�DK'xv
�e]r���i.	�W�ɱ�����H���q^��,Jp
����p]�n�Hp`q�|�u-��;o�� :�)��;���.U6
�S�rK�b�Y��J$�YMvd݉i���-���ָG:��X��v�U]��z]�}a����=_��ι��-ln���h�9��#X_�v4R�z7;r���7ܬ�d�Y��$�fӮ3�ؒ�����$��7q��.8y�3�\��E�d�5G�lr��w�bN��Fvi>�Bv�n�4�J��1���{^6�~Ġ��Ց��m~�H����'�a�l���sM��'�[����j>���ܻ�{>]&Ft������p	R������]%���R���c���ұ��%�����J�]�R���W:q�@��5�u�N���+c�� H?������>*q�雗�=)\��ɢ ��m!)xn��&-��K��$DL�v�n�A�U�ق���NϠΠ�(�:MI�Ge��(Cij��o���e���"?1�-�c�]j��>a���4H}h>���FRf$&�.�o��pm�����yb��2ǘː����+F̑�;�(������0Ͻ��_� ��=P7���,��ߜ?�c��F9�4�W�ZoOz�jy�JL�sQ��m%L=��ZK�S�$�7��f�A �
��g&�9]�2f
 ���]��B�a?��=J���Ӡ��������yMI7kQ�R�拧��9�'���r�k���rceu,��o��7{��T��t�iE㇊��:�І���X�=lA*��.��9����Z�1a��v�ҹj���e��n�W�U��}d�_�/Έx���,�i#�C:<(פ*�ʟ���7�։��,0��N��%�%���z-í�}��E�:�kX�b��ߥ����,F�#i��k�F����[j�d� 5�J*�y��������9��]�f��5n�%���"�m�J>A�m$K���G�x\t�N��<�{����ܰA�d!���=� ��mI���e��T����o�g^f7�r�.7���`�Pb�`�y���w�$�����8���<��F\��Y�W��!�7�����@dq%��J�2$Nms=%�ͧu;�k*�Ȥ���9�U��џ�Q�RN��$>����쿃���m7O����!x��o��r���a�zn:�I�%��cN��_*�3�R�?�#S捙�\��m�=����&E�^�[ϗ*hcH9Y�i����P�g������������L��i8<U!��E��a��P�8l;��sN/�ρS�	얊��� ��#τ�ڊ~<x7b�?%*��r������1���� �*D�����}7���7���K��\q2��a:	��Z�y���-�nj����]7q�j�����BVm'�TCHǘ���n�YcZL���"'�`���`2�R����'�I��!�?�過��^��� �A�p+5���+��{Gn
� �8�/��eg�:�Z'U����5,GXe��N���[����+3���ѿ�����\"���H��:��X0�d=w��Nu�`i�K���a��rOrK�����1�u
�'b> ���N�w��$X���c��{���    A�L�,��})]�'1���|�)�g��;�\mi^������籚�c�^�7G �ٺ�/�$�8ML��o3(Έ���-/Swd%�����Ѓ��$Ə�R~o}��2�"y��[/Ɛi�i���9���N�?�nڮ�<%A�Y<��[r�u_�2����z<�0��Kq����a�+W��:"a��,��⮦��%-A�z��P����=�xe61�y��Ӓ'�n���՚-�	1�ٗd�In��n�	6`ju
+w�z��	�	�ɋ��Nl�R|?F�tJ�%��3�B�~MVk�>�}�=�fр]��l�QD:������8I�.�����DRsI!���M�gN���G���[�ְ��"=o|���K���𘜿� �I��Zm��z&�\� 콑����)s��g4%Ge�a����Fd��d_t����.��V�N�@ȹ���ԯ�K�Q�	�*���Tƃ���7��'��r�}��;�S��V�T3H�&�l�������ɯ��"2�.�R?�$�W���s�w���Ǽ�DƝl�Ս3n0���1^�6�)�?S|�=��9�78���SC��Ց�Yf�廑b"�(;9��E��E�r������HuƲ�D܁Ar�(�|4S�N�H��y��D��r�73wރ������:��ss>L�'h�<Y6|T�s^�E�'�<�Dɤ�W��5^7��$Y�1�CR���U=X;"*���M��gC�eX���������E���aIc��5\���+�p� ��/���
��d�Z�=�N���Mh���c�W��T�iW2�XA�idF;ɻ{Ѧ��B��K��.#�_S����6��N�[��k�Q"�g^��W@�$	f�Ŵ�>E.���2ͽ��L�BTK�e� ���������}���;KEg����zZ'$%wnO�tg���ڔ:�<��<w)�%I�}��KMJߠn��,�0y�9��柯�l�Qѥ�0��%�b�Ug�A��z������ry��Ẋgx=��]��g���B�7�&�u+(f#���^r��IO�~��r����v{"��}k_O�,v���`(7�ȶ�'�'a�FMV��Y?��}pDKAu]|*S��.���J�{��>TzVj?�w��sH�Ղ�rj�~��+�G���*�&?�\���R��H�h��Q��������mN8�ӈX���9:q,\�<�mI� \1W`�7�n����j��R�e��H����>`_"�0���UecßlI������oO���V\��Y֕}7��������7D~��-�
�g�wEj��.\���vy�a(��F�k���XE��ۦG��r$��2�i`�78�E�S<Z�kLx��z�'���t�z?M-�T�2���؇s4�#�i�W�-�Y*ms�\���!!���-���v�KKŚi �<�`7��a�����hEQ�R��'��<��(s�t �D�?�.W�ۮ>�%�m��AKF>�?�ڄ���|to��s�-Eͼ .�W��'�0 O�������{0Q��}���ƽ�r�n�n�rs ������i���o5(��x219I\ၒd���
Pa�FJ`���4Nk��L9f�wHӠYdO�M�8��|hB8ؒ�ww��5Ԥ͞��Zt܂mцx��!���YN��flo~�D̠�<,���ԟ�'�f�d!��[�*U!_�ܧ�tu҈���d!��	y��y;���O���O��M�my���y�DJ������%NI$��i0/�!
<�A�
}�`
fqm�PJZ�T���<�Wek�0AJF^�J0�\��0w�&��V��D�a"���z#ϵ�<�xj�`V��hͯ�܆a�g���uC^޴��V�dg�/ln��X��<�E�|�A��I�×h�1a�\����(,����ol�5����5ֹ�% i���N�{����!���ATԘCy&��W��b4l�G+$1���ZKG�^93z%~��b�d>J�j���[��-��^N'��Q��qRR����L�t�ڞW��Z�
c�;}�"���D_�9�QI����#g$�w'�];�[��g�3}yG	�yCw~�Ğ��S�Ë����&6��T��RS!����e���W2Pi�J�ilD�c�=�E���e������#�0�.z�:~R�Or
���V0�|.cKR��XQe��Sv]\�Ub�-5�<t�~	1��S^p���J�E���H2ҝ$Sd|�����=��&r�F�T6��5^��~�����}�����bN��	�u��		T�y`d��C`\lIP-o�uYNq����*r����Ӓ?�{5꼉�G���}�w�)���+p�����n�������oAx/y�܌�����0d��64�xu�����V���S�}��K��U{^n9���-�u�v��)�����S��|��b#�,l�,�/yUه�i�z��\>�ű|�t���S��ɬ�X�;``3�Z���4�ǹ��ʩ�(�{�De�~KS��o����
�ъ�@�.\[Xx����'|��{wc��S�;���,�9H�Z]+=%2��	��h�v���?D��=^���wBf�����9����z$��n k�z���6N�ի��n�J�e��%��i}��"A^ź�x�>���	�C��������F�r���X�����aO��Me�X�[�(M+n�횱����d���}������%��o�i�)!��~S�!!�鞚Z��bB�2r7��y�K�������������2*y������[�n��XKH�E��{߯E����%1�n�V�tv'9O�'�<�7��F��H�6�,:�#�S��?.�^ζ�s书��h��LD��_��տ5�%�L���Hh��J*�}_� HI���l�_���g��ѝ�,1�䇈ejޤ���IzP>Ir	D�g�G�ރ�j�ֆj��J��<䝱P
D��:y� @"-�M+�)�iӯ�7��1�� v�:+{_!4�g��w�ʌ��P�Kj߄�Qn4C����}�Xw�)���)�V�>�Ϙ�H��N�|U(���%Zr3�q�Y��p�m�e��=ޜ!�$4��K�D���`���TsR�~{�as���`'2�~BYrl@����N�!�wL}1���a';��:�����f�i���s:��#ڛ}{h#-�|��=G��`K�
�� �8�P��%����~�z%�j꜍��nMP�����Tl��&x1Ot�[��?>��NKG�:�6��N%�91N�42�YkL�13*y�/x�\�̣?���Aˇ/o�@>��oEL9�%Z���ɧ9]9@D�R������LB�a1�3�Un/���Hz��`��W���nm�i�0�j�kuj3���C�� IUO~��߯�zYqc�3}����%��_n���ƶ	��e
������-k���k�<�Qڮ;p�)����f��
��;�kԥ>iT�<%X	8G���B꡷��/-�i��߭����.��}�rŁ(�\{y�/瞋�����ܜ�ؚ����}�=f�G19�T��I]���ã���M	r����˟{v�����Y�5��
�{�����
��qr����QC��]���m*������H2ٽ>{o7q�-h�ɱ{�ERe'gs��W�@��ɳ�p�A^k�]�C��4�H/�����j� wG�<U\��MUw'���J$0Hx�Bb�b��.��5LI!��b`Hx%�d�jY�t���5%I�{�bz]|ܛ��m�{R>۹�cgaw�7YY��Δ\��_Ô�ȩ�I�/i夤�M�A�>�kA��O{��k�IՈ���^b�Nt���wE}�O��Dϒ�A@�V�oRS`�Ș�b��&��	�vG�-r=x����$;��Mrr4�˽��K	fi%'��l��<f��浄:yJ6�a	aǽ�~���G)��L�ؕ��<wų+�щ��5�������97T�ȅ[�O�e%{�t��0�:w�(%o�9�� h	 g�,֏��Tv���-/1iÏ��b��<�x���|40�b�J? �
  ���Sh�(�#�\K�u�%���G�*�	�A0�3�|K�/�+������mT�LP�G*�2��#M��R�(�w�ۃO�e�o_�Z����=_�+��ٜ������}��u�)H$^�[����8E�&����e;vV���۲�Rv��o~P���~ҍ^�N�����=�=��'[~�eeG� $��r�v;�9%��2ԉ~w��ѥT#ݖ���%�+ϝ�eb�6`��7��Z o�4N&�9j��Rry�Bqi�[gL�JN�uZ�~���R�}�oI�5t*6��v�4I��6�d���%-]�������*ֹږ�&�������,�Ҁ���i��ra�7�r�I.���yw̆fGa��H�>( -VY���f��L�_�A����Y_�E:�ث�;������[	�8����w%ݜ6٘Z	��M���o"nI/&�|����<���=?�z�.��_O���_iw�m�։%�D�?qQm�{�.�x
� I�ޛ��=W}	�=��V�����.I�� Z��r��W��x��Nr�kRX����m�_��> 1t�k�Ȧ����n��pb��!2|8�O���m�j
�]�MD�����V��N8g��>��̠l�KY�R2�AK]�cIU/7�Zz�?8x�W�ɟ�:�Yɀ�rY·	0���a9)���2ذ�안X v���H���g�������[���7ɡ^ġ��Z��w��ݾhg!������47����Ns����u����^(;�s�D�����K�9!7��\�<I��GK:y�,{�y�G~��e��u��VTؼ�������e�M�čL&�t.%���7V\y�ך��X��ĸ)}$�0Pj���G(���S��R���!,����N����R4$F�3;عZ9�J{����d}��a�)�&4�:��QB)��o/LY�Ǵ�8-���S'mJ5pF���VrRt�x�1�R-KR�i4�Q�i5����J��hAv �U����L�]��gP>MyS��E�>�S����:�rϐ��Cs.�����RKwUىbW �_��>�3�H�<r��<zYk�#@N� �)�|Q�ty�������B������;�m.�
93Ϭh�y�©D�y��*��#wdc줄��S�� �c��7�g��{����Z�L�����ǖ��NA_l�<���)��i��8^Au�Ľ���ݵ�5��fL�׶��(o#�$Q�� iV��d�7�>_t��n��B��Zť�LhfiJ%��c3R=	ՃE�=��L��r}R��YV�T��@��d�s�[/N9�&��e0z�vԩ\�_kr�/���ɭ�l�|��x�����?pr�k�}�M���_��S#����j�����=�i;,�9'��*����~���D�$D�Y��� ڸ�s�L1C��/F�o�������'����B%��)�����%�g2�N
qVѝ��A�(wΣ��%2W�j��{��E���{R�d0�w�JB������(=��7{�D�7�n�K�3���8�����A􂍥[ҁՆ9��Z�e?Ɉ����B:1�'������h�W�/Հ�2C>��tR�}�dʠ<(�� �P�n����X�WM���[h���%&U?�G 7�j~y>�h�y�cx��ڍ.���N�51�N'곜)�8�9q�'<LS��,������r~{�K���d����Ă=w}H��$>l&��?,ٔbU@�
�0y:J"����̃��nn���{���SE+0�k����'�R���|�$/L��1���䱸�l3k�3wK��P�°� �aK�6�����,1}ʧg�@Gw<�%s�����q�Ri&'�}}_~N "��Ԅ��@��|SaV_�6<��8�[�a2�$MP{/���5k�M�4y�gIL���T{IʣAG�Ih�%�ǚd<>�e�构�0���J �v[r���嫩Oij������A�.W��%�Iq&��=K�Oev=v_N�
tK�X�t��}�e��-ؚ_�
��I�_Pj�kͩp�$ki�����E=�~���}�]d��3I˟� ]|�>�'��5�Ȫ�u���D�Vk�G���Os��/�����$Q�)�:?���g��S�[�h�&��Xד��[R��Lڴ��T������$�| D�@�AEJ��]��?�Ь]_�K�� ��=&<`@�H>�,	FHxW�QӡlD�,�~���ǹ݃�cb�{~Ǆ�Y�����R&'}�Oɳ���]*����}��v־�6���ASg�m�c�#�������{)��U�9g�����H��Q��r*Rĉ�
�9w�\���^�?����
*0ߤp�gZw9o�uH�k�1%?�Sq����8e6���(�9-־/�3-��F�'0 �T�!�7���6r ���~/߃0*��>qaH��}3�D'>�)�8��c�"ڧ�I��a����y	��Вc��_�?gP�c�~'1�]���̟����M����R�{�&���d&Z�~�'f�O�'U�1�H�����(��7Un�o����4��Ú��	��9����I�St{כ��W{ll�纡���_˘�R���>�o����~m��ߖ���Ҹt&��?��5�W�ܼ��ay�񫌆͒d����_���j0?y1J�\����f�A�迓����_��o�?@-            x������ � �     