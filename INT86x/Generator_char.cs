﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INT86x
{
    public class Generator_char
    {
        public static string gen()
        {
            Random rand;
            rand = new Random();
            char[] rnd_char = { '☼', '◙', '♂', '♀', '♪', '♫', '►', '◄', '↕', '¶', '▬', '☺', '☻', '♥', '♦', '♣', '♠',
            '•', '◘', '○', '▲', '▼', 'ž', 'ř', 'č', 'é', 'í', 'ÿ', 'ï', 'ä', 'ö', 'ó', 'š', 'ě', '╚', '╔',
            '╩', '╠', '╬', '╧', '╤', '╥', '↑', '■', '±', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'œ', 'Ÿ', '¼', '½',
            '¾', 'ń', '£', '¤', '¥', 'Â' , '¢', 'Æ', 'Ç', '«', '¬', '®' , 'å', 'ß', 'ø', 'õ', '×', 'ñ' , 'æ', '√', 'ε',
            '₧', 'Σ', 'σ' , 'µ', '█', '▄', '▌', '▐', '▀', '∞', 'π', '≈', 'φ', '²', '∩', '—' ,'™',  'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '餐', '厅', '视', '电', '蛋', '鸡', '笔', '钢', '车', '伞', '钻', '绿', '话', '电', '猪', '红', '雨', '蓝', '鱼', '鹅',
            '÷', '＝', '≠', '＜', '＞', '≦', '≧', '∞', '∴', '♂', '♀', '°', '′', '″', '℃', '￥', '℡', '℻', '☘', '☠', '☹', '☺', '☻', '✊', '✋', '✌', '✍',
            'あ', 'い', 'う', 'え', 'お', 'か', 'き', 'く', 'け', 'こ', 'さ', 'し', 'す', 'せ', 'そ', 'た', 'ち', 'つ', 'て', 'と', 'な', 'に', 'ぬ', 'ね', 'の', 'は', 'ひ', 'ふ', 'へ', 'ほ', 'ま', 'み', 'む', 'め', 'も', 'や', 'ゆ', 'よ', 'ら', 'り', 'る', 'れ', 'ろ', 'わ', 'を', 'ん',
            'ア', 'イ', 'ウ', 'エ', 'オ', 'カ', 'キ', 'ク', 'ケ', 'コ', 'サ', 'シ', 'ス', 'セ', 'ソ', 'タ', 'チ', 'ツ', 'テ', 'ト', 'ナ', 'ニ', 'ヌ', 'ネ', 'ノ', 'ハ', 'ヒ', 'フ', 'ヘ', 'ホ', 'マ', 'ミ', 'ム', 'メ', 'モ', 'ヤ', 'ユ', 'ヨ', 'ラ', 'リ', 'ル', 'レ', 'ロ', 'ワ', 'ヲ', 'ン' };
            string rnd_name;
            string rnd_str = "";
            for (int num = 0; num < 14; num++)
            {
                rnd_name = rnd_char[rand.Next(rnd_char.Length)].ToString();
                rnd_str = rnd_str + rnd_name;
            }
            return rnd_str;
        }
    }
}
