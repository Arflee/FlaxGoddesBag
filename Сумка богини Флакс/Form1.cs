﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Сумка_богини_Флакс
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        public void btn_raschet_Click(object sender, EventArgs e)
        {
            string func1(int val)
            {
                string[] sumka = new string[100]
                {
                "1. Забирает случайный предмет из определенного списка у открывшего сумку и исчезает",
                "2. Две игральные кости",
                "3. Алхимический дым (Заполняет куб 3х3 клетки дымом)",
                "4. Лом",
                "5. Комплект Целителя",
                "6. Бутыль масла",
                "7. Кожанный доспех",
                "8. 3 ягоды насыщения восстанавливающие 1 хп каждая",
                "9. Бутылка вина",
                "10. Ягодный торт",
                "11. Малое зелье лечения",
                "12. Афродизиак",
                "13. Антидот",
                "14. Зелье силы",
                "15. Зелье увелечения",
                "16. Зелье сопротивления огню",
                "17. Флакон яда",
                "18. Зелье сопротивления некротической энергии",
                "19. Зелья подводного дыхания",
                "20. Зелье ясности ума",
                "21. Свиток заклинания 'Огненный шар'",
                "22. Свиток заклинания 'Контрзаклинание'",
                "23. Свиток заклинания 'Леомундова Хижина'",
                "24. Свиток заклинания 'Молния'",
                "25. Свиток заклинания 'Полет'",
                "26. Свиток заклинания 'Разговор с растениями'",
                "27. Свиток заклинания 'Разговор с мертвыми'",
                "28. Свиток заклинания 'Газообразная форма'",
                "29. Свиток заклинания 'Проклятие'",
                "30. Свиток заклинания 'Возрождение'",
                "31. Перчатки атлета \n(+3 к проверкам атлетики если надеты)",
                "32. Воротник красноречия \n(+3 к проверкам убеждения если надет)",
                "33. Браслет трюкача \n(+3 к проверкам акробатики если надет)",
                "34. Брошь чувства магии \n(+3 к проверкам магии если надета)",
                "35. Ожерелье пантеона \n(+3 к проверкам религии если надето)",
                "36. Очки пронизательности \n(+3 к проницательности если надеты)",
                "37. Плащ маскировки \n(+3 к проверкам скрытности если надет)",
                "38. Венец истории \n(+3 к проверкам истории если надет)",
                "39. Сапоги-скороходы \n(+10 футов к перемещению если надеты)",
                "40. Пояс крепи \n(+ХП равное мод. ТЕЛ + БМ если надет)",
                "41. Флейта очарования \n(Слышащие флейту нейтральные существа становятся вам друзьями на следующие 3 часа.\n Повторить эффект можно только через 3 суток)",
                "42. Барабан доблести \n(Вдохновляет играющего и его союзников, следующие 3 часа они не могут быть испуганы.\n Эффект можно повторить только через 3 суток)",
                "43. Свирель спокойствия \n(Снижает агрессию и страх примитивных существ)",
                "44. Бубен упорных танцев \n(Если танцевать по кругу, ударяя в бубен, и петь, то сломанная вещь в центре круга с шансом 50% починится.\n Повторно применить бубен можно через сутки)",
                "45. Лютня жизни \n(Во время короткого отдыха увеличивает восстановление ХП всех, кто слышит игру на лютне на 10.\n Эффект можно повторить только после длинного отдыха)",
                "46. Демонический варган \n(Если играть в течение минуты, все, кто слышали мелодию, получат временные хиты в размере уровня существа + БМ на 3 часа.\n Повторно получить эти временные хиты можно только после длинного отдыха)",
                "47. Святой горн \n(Если подуть в него, никоуровневая нежить в радиусе 40 футов получает помеху на атаки по вам.\n Повторно горн можно применить через 2 суток)",
                "48. Лира дриад \n(Игра на лире, в течение минуты убедит растения в радиусе 100 метров помочь вам.\nЭффект можно повторить только через 3 суток)",
                "49. Треугольник маначастиц \n(Если ударить, образует энерговолну в радиусе 60 футов, которая на 10 секунд подсветит маначастицы.\nПовторно эффект можно применить через сутки)",
                "50. Кларнет из коралла \n(Позволяет играющему ходить по воде, требует концентрации, нельзя пройти больше 70 футов.\n Повторно применить кларнет можно через сутки)",
                "51. Амулет сопротивления некротической энергии \n(Снижение урона от некротической энергии на 50% пока носишь амулет)",
                "52. Амулет восстановления \n(Когда бросаешь кость на восстановление хитов, добавь +2 пока носишь амулет)",
                "53. Амулет заговора \n(Узнаешь один заговор из списка заклинаний волшебника пока носишь амулет)",
                "54. Амулет защиты от проклятий \n(Носитель защищен от проклятий накладываемых другими существами)",
                "55. Амулет Богини Флакс \n(Можешь перебросить любую кость один раз и выбрать результат, после чего нужно совершить длинный отдых, чтобы снова использовать амулет)",
                "56. Амулет сопротивления яду \n(Снижение урона от яда на 50% пока носишь амулет)",
                "57. Амулет сопротивления холоду \n(Снижение урона от холода на 50% пока носишь амулет)",
                "58. Амулет инициативы \n(+3 к броскам инициативы пока носишь амулет)",
                "59. Амулет вампира \n(Каждый раз, нанося урон атакой, ты восстанавливаешь 2 ХП пока носишь амулет, лимит восстановленного таким образом ХП 20 ХП в сутки)",
                "60. Амулет сопротивления огню \n(Снижение урона от огня на 50% пока носишь амулет)",
                "61. Убийца великанов \n(Мифический клинок, несущий смерть великанам. +доп. мод Силы/ловкости урона против великанов)",
                "62. Орудие тысячи форм \n(Принимает любой вид оружия, из тех что видел владелец, магические свойства и тд и тп не передаются, только форма)",
                "63. Лук-драконоборец \n(Мифический лук, сражающий драконов, +доп. мод Ловкости урона против драконов)",
                "64. Святокрест \n(Мифический меч, в виде креста, которого боится вся нежить, +доп. мод Харизмы к урону против нежити)",
                "65. Ядовитый клык \n(Мифический кинжал производящий яд, +1d8 урона ядом)",
                "66. Атакующий щит \n(наполовину щит-наполовину меч, +1 к КД, 1d8 + мод. Силы + 1 колющего урона)",
                "67. Меч-секира палача демонов \n(Наполовину секира-наполовину меч, универсальное оружие (в одной руке меч - 1d6 колющего, в двух руках превращается в секиру 2d6 рубящего, + доп. мод. Силы к урону против демонов)",
                "68. Кровавый клык \n(Двуручный меч, который при нанесении урона дает владельцу временные хиты, в размере Мод. Тел. + мод. Силы)",
                "69. Кинжалы телепортации \n(Два кинжала, на 1d4 урона. Владелец кинжалов может как телепортироваться к одному из кинжалов, в радиусе 70 футов. Так и вернуть кинжалы к себе в том же радиусе)",
                "70. Сумеречный жнец \n(Коса на 1d6 урона, души убитых пораженные этой косой - поглощаются ей, за каждые 20 душ кость урона косы увеличивается на порядок, вплоть до 1d20. Души примитивных существ не поглощаются)",
                "71. Кольцо хранителя тайн \n(Один раз в сутки носитель может получить ячейку заклинаний 2-го уровня. Если носитель заклинатель или полузаклинатель - он может потратить ее на заклинание из списка своего класса, если нет - то тогда он может потратить ее на заклинание из списка заклинаний волшебника. Характеристикой для этого заклинания в последнем случае будет интеллект)",
                "72. Кольца высшей связи \n(Между одевшими эти кольца возникает мистическая связь. Когда кто-то из носителей получает урон, из этого урона вычитается 1d4 урона, а далее урон распределяется между носителями поровну. То же самое происходит с лечением)",
                "73. Кольцо заговорщика \n(Носитель узнает один любой заговор на свой выбор и может его использовать, пока носит это кольцо)",
                "74. Кольцо железного кулака \n(Безоружные удары носителя наносят 1d8 урона + мод. Силы)",
                "75. Кольцо магических секретов \n(Заклинания/заговоры носителя, наносящие урон, получают +1 к урону, заклинания, требующие спасброска, повышают СЛ спасброска носителя на 1)",
                "76. Кольцо щитоносца \n(Кольцо генерирует небольшой полупрозрачный барьер, похожий на щит, носитель кольца получает +1 к КД)",
                "77. Кольцо телекинеза \n(Носитель получает способность к телекинезу, он может перемещать небольшие объекты весом до 2 килограмм)",
                "78. Кольцо трансцендентности \n(Носитель совершает спасброски телосложения для поддержания концентрации с преимуществом. Если носитель не заклинатель, тогда враги не получают преимущества, если окружат носителя)",
                "79. Кольцо пламенных кузен \n(У кольца 3 заряда, которые восстанавливаются после продолжительного отдыха. Потратив заряд, носитель может придать любую форму небольшому металлическому объекту, весом не больше 5 килограмм)",
                "80. Кольцо тысячи языков \n(Позволяет носителю говорить на любом языке и понимать любой язык. Письменность этих языков, кроме тех, что носитель выучил сам, все еще остается неизвестна)",
                "81. Маска столикого \n(Магический артефакт, мертвого полубога. Надевший маску может поменять свой облик на облик другого гуманоида, вместе с одеждой. Маска сливается с кожей, и что бы ее снять надо потянуть за ухо от лица, после чего носитель возвращает свой облик, держа в руках маску)",
                "82. Семимильный лук \n(Легендарный лук древнего героя. Для этого лука отсутствует максимальная дистанция. За каждые 20 футов расстояния до цели, наносится дополнительная единица урона. Магический модификатор лука +1)",
                "83. Меч-кладенец \n(Легендарный одноручный меч. Игнорирует броню, доспехи и щиты, не распространяется на природный доспех. Сложность попадания рассчитывается по формуле 8 + Лов. цели. Урон меча 1d10 + мод. Силы + 1. Ревнивец: если вы пользуетесь другим оружием помимо меча кладенца, превращается в обычный меч на 1d8)",
                "84. Ледяная дубина короля Йотунов \n(Легендарная двуручная дубина. 1d8 + мод. Силы урона. Владелец может действием активировать древнюю магию Йотунов, и стать на размер больше вместе с дубиной в течение минуты. В таком состоянии дубина наносит 2d8 + мод. Силы урона. Также, при попадании причиняет урон 1d6 холодом один раз за ход. Повторно применить способность можно после длинного отдыха)",
                "85. Плащ наследника драконов \n(Плащ, покрытый красной чешуёй дракона. Носитель получает сопротивление к огню, +1 к КД, и может бонусным действием выдыхать огонь, нанося 1d8 + мод МДР урона)",
                "86. Карта шута из колоды демонов \n(Демонический артефакт. +10 к обману если Демон-шут в маске комедии. +10 к проницательности если в маске трагедии. Маску можно менять один раз, после продолжительного отдыха, трижды перевернув карту)",
                "87. Фолиант тайной магии \n(Легендарный фолиант. Снимает ограничение на количество заклинаний в ход. Владелец может восстановить одну ячейку равную половине своего уровня, округленного в большую сторону, после чего он может сделать это еще раз, после длинного отдыха. Магический модификатор +1. Может быть фокусировкой)",
                "88. Меч пророка \n(Легендарный двуручный меч. 2d6 + мод. Силы урона, позволяет владельцу предугадывать действия противника, которые он видит в отражении меча. Используя меч, владелец может реакцией парировать атаки, как если бы он делал это с чертой 'Оборонительный дуэлянт', так же можно реакцией получить преимущество на спасброски против заклинаний, направленных на владельца меча)",
                "89. Амулет второго шанса \n(Легендарный амулет. Если надеть его, то снять насильно не получится. После того как персонаж проваливает последний спасбросок от смерти, он воскресает с половиной ХП)",
                "90. Крылатые сапоги \n(Дают носителю скорость полета равную 30 футам)",
                "91. Камень Интеллекта \n(Одноразовый легендарный артефакт, если сжать в руке, рассыпится в пыль, а сделавший это получит +1 к значению Интеллекта)",
                "92. Камень Харизмы \n(Одноразовый легендарный артефакт, если сжать в руке, рассыпится в пыль, а сделавший это получит +1 к значению Харизмы)",
                "93. Камень Мудрости \n(Одноразовый легендарный артефакт, если сжать в руке, рассыпится в пыль, а сделавший это получит +1 к значению Мудрости)",
                "94. Камень Силы \n(Одноразовый легендарный артефакт, если сжать в руке, рассыпится в пыль, а сделавший это получит +1 к значению Силы)",
                "95. Камень Телосложения \n(Одноразовый легендарный артефакт, если сжать в руке, рассыпится в пыль, а сделавший это получит +1 к значению Телосложения)",
                "96. Камень Ловкости \n(Одноразовый легендарный артефакт, если сжать в руке, рассыпится в пыль, а сделавший это получит +1 к значению Ловкости)",
                "97. Бездонная сумка \n(Может хранить неограниченное количество предметов)",
                "98. Очки истинны \n(Позволяют видеть истинное естество объектов, например сквозь любые иллюзии, или видеть перевертышей и т.п.)",
                "99. Фамильяр \n(Как от эффекта заклинания поиск фамильяра. Если у вас уже есть фамильяры, то фамиляр, полученный из сумки, будет дополнительным)",
                "100. Артефакт божественного класса \n(Бросьте дополнительный 1d10)"
                };
                return (sumka[val - 1]);
            }
            Random random = new Random();
            int roll;
            if (textBox_main.Text == string.Empty)
            {
                roll = random.Next(1, 100);

            }
            else
            {
                bool is_number = int.TryParse(textBox_main.Text, out roll);
                if (is_number == false)
                {
                    MessageBox.Show(this, "Введите число от 1 до 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (roll < 1 || roll > 100)
            {
                MessageBox.Show(this, "Введите число от 1 до 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            label2.Font = new Font("Microsoft Sans Serif", 12);
            label2.Text = func1(roll);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}