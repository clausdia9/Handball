var NewsService = function () {
    var _news = [
        {
            Id: "1",
            Title: "Win win win",
            Author: "Kara Denvers",
            Description: "The team won the game yesterday! A game consists of two 30-minute halves with an intermission, and players wear no protective equipment. The ball is moved by passing, dribbling, or hitting it with any part of the body above the knee. In handball, only the goalkeeper may kick the ball. Running more than three steps with the ball and holding it longer than three seconds are illegal.There is evidence of ancient Roman women playing a version of handball called expulsim ludere.[3] There are records of handball-like games in medieval France, and among the Inuit in Greenland, in the Middle Ages. By the 19th century, there existed similar games of håndbold from Denmark, házená in the Czech Republic, handbol in Ukraine, and torball in Germany.[4]The team handball game of today was codified at the end of the 19th century in northern Europe—primarily in Denmark, Germany, Norway and Sweden. The first written set of team handball rules was published in 1906 by the Danish gym teacher, lieutenant and Olympic medalist Holger Nielsen from Ordrup grammar school, north of Copenhagen. The modern set of rules was published on 29 October 1917 by Max Heiser, Karl Schelenz, and Erich Konigh from Germany. After 1919 these rules were improved by Karl Schelenz.The first international games were played under these rules, between Germany and Belgium by men in 1925 and between Germany and Austria by women in 1930.In 1926, the Congress of the International Amateur Athletics Federation nominated a committee to draw up international rules for field handball. The International Amateur Handball Federation was formed in 1928 and later the International Handball Federation was formed in 1946.Men's field handball was played at the 1936 Summer Olympics in Berlin. During the next several decades, indoor handball flourished and evolved in the Scandinavian countries. The sport re-emerged onto the world stage as team handball for the 1972 Summer Olympics in Munich. Women's team handball was added at the 1976 Summer Olympics in Montreal.Due to its popularity in the region, the Eastern European countries that refined the event became the dominant force in the sport when it was reintroduced.The International Handball Federation organised the men's world championship in 1938 and every four (sometimes three) years from World War II to 1995. Since the 1995 world championship in Iceland, the competition has been held every two years. The women's world championship has been held since 1957. The IHF also organizes women's and men's junior world championships.By July 2009, the IHF listed 166 member federations - approximately 795,000 teams and 19 million players."
        },
        {
            Id: "2",
            Title: "Big game tonight",
            Author: "Alice Ionescu",
            Description: "The most important game of the season! A game consists of two 30-minute halves with an intermission, and players wear no protective equipment. The ball is moved by passing, dribbling, or hitting it with any part of the body above the knee. In handball, only the goalkeeper may kick the ball. Running more than three steps with the ball and holding it longer than three seconds are illegal."
        },
        {
            Id: "3",
            Title: "Merry Christmas from Blue Ravens!",
            Author: "Kara Denvers",
            Description: "Merry Christmas everyone! A game consists of two 30-minute halves with an intermission, and players wear no protective equipment. The ball is moved by passing, dribbling, or hitting it with any part of the body above the knee. In handball, only the goalkeeper may kick the ball. Running more than three steps with the ball and holding it longer than three seconds are illegal."
        },
        {
            Id: "4",
            Title: "The top scorer of the season is the captain of our team!",
            Author: "Kara Denvers",
            Description: "Attacking players must take their shots at goal from outside an arc marked on the playing surface, within which only the defending goalkeeper may play. Free throws (usually passes to a teammate) are awarded for minor violations of rules and taken from the spot of the violation or from a line a short distance outside the goal area, or circle. Penalty throws at goal are awarded for more serious infractions and are taken from a penalty mark just outside the circle and directly in front of the goal."
        },
    ];

    this.ReadAll = function () {
        return _news;
    }

    this.ReadById = function (id) {
        for (var index = 0; index < _news.length; index++) {
            if (index == _news[index].Id) {
                return _news[index];
            }
        }

        return null;
    }
}