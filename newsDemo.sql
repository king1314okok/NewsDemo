/*
 Navicat Premium Data Transfer

 Source Server         : 上海
 Source Server Type    : MySQL
 Source Server Version : 50724
 Source Host           : 101.132.164.250:3306
 Source Schema         : newsDemo

 Target Server Type    : MySQL
 Target Server Version : 50724
 File Encoding         : 65001

 Date: 21/05/2019 19:42:07
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for editedPage
-- ----------------------------
DROP TABLE IF EXISTS `editedPage`;
CREATE TABLE `editedPage`  (
  `id` int(8) NOT NULL,
  `Eid` int(8) NOT NULL,
  PRIMARY KEY (`id`, `Eid`) USING BTREE,
  INDEX `fk_Eid`(`Eid`) USING BTREE,
  CONSTRAINT `editedPage_ibfk_1` FOREIGN KEY (`id`) REFERENCES `news` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `editedPage_ibfk_2` FOREIGN KEY (`Eid`) REFERENCES `editor` (`Eid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of editedPage
-- ----------------------------
INSERT INTO `editedPage` VALUES (994903, 1);
INSERT INTO `editedPage` VALUES (995256, 1);
INSERT INTO `editedPage` VALUES (997487, 1);
INSERT INTO `editedPage` VALUES (995079, 2);
INSERT INTO `editedPage` VALUES (995682, 2);
INSERT INTO `editedPage` VALUES (999775, 3);
INSERT INTO `editedPage` VALUES (999782, 4);
INSERT INTO `editedPage` VALUES (999942, 4);
INSERT INTO `editedPage` VALUES (999947, 4);
INSERT INTO `editedPage` VALUES (999885, 5);
INSERT INTO `editedPage` VALUES (999910, 5);
INSERT INTO `editedPage` VALUES (999935, 5);

-- ----------------------------
-- Table structure for editor
-- ----------------------------
DROP TABLE IF EXISTS `editor`;
CREATE TABLE `editor`  (
  `Eid` int(8) NOT NULL DEFAULT 0,
  `Ename` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Edepart` varchar(20) CHARACTER SET utf32 COLLATE utf32_general_ci NOT NULL,
  PRIMARY KEY (`Eid`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of editor
-- ----------------------------
INSERT INTO `editor` VALUES (1, '宁静海', '动漫星空');
INSERT INTO `editor` VALUES (2, '室见立华', '动漫星空');
INSERT INTO `editor` VALUES (3, '加雷斯悟空', '互联网');
INSERT INTO `editor` VALUES (4, '短笛酱', '游民星空');
INSERT INTO `editor` VALUES (5, '小熊桑', '游民星空');

-- ----------------------------
-- Table structure for news
-- ----------------------------
DROP TABLE IF EXISTS `news`;
CREATE TABLE `news`  (
  `id` int(8) NOT NULL DEFAULT 0,
  `title` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `content` varchar(1000) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `dateYM` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `picUrl` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `url` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of news
-- ----------------------------
INSERT INTO `news` VALUES (994903, '《Fate/Apocrypha》白衣贞德手办 红莲之圣女霸气登场', '在TV动画《Fate/Apocrypha》第24话中，初次揭晓的宝具“红莲之圣女”发动时的情形一定让大家印象极为深刻，现在手办厂商GSC将其中身着雪白圣衣的贞德推出了全新的手办。这款手办中的贞德有着如圣女一般通透雪白的肌肤和温柔微笑着的表情，手持宝具“红莲之圣女(La Pucelle)”身着威威闪耀的盔甲，展现出火刑的火焰特效。红莲之圣女以“主呀，委以此身――”这句临终诗作为发动的咒文，让火焰显现的圣剑。将贞德的烤刑诠释成攻击而产生的概念结晶武装。固有结界的亚种，将心象世界结晶化而成的剑。由于此剑正是英灵贞德其本身，所以一旦让宝具显现，战斗结束后贞德就会从现世消失。', '201712', 'http://img1.gamersky.com/image2017/12/20171225_lr_176_4/gamersky_01small_02_201712251454B77.jpg', 'http://acg.gamersky.com/otaku/zb/201712/994903.shtml');
INSERT INTO `news` VALUES (995079, '《调教咖啡厅》樱之宫莓香手办 抖S少女等你抱回家', '作为10月新番《调教咖啡厅》的女主角，有着漂亮双马尾的抖S少女樱之宫莓香成为许多漫迷的新“老婆”，而下面这款由Aniplex推出的莓香手办将再度激起各位的爱意。尽管从正面来看面部造型有些崩坏，但这款莓香手办整体造型还是赏心悦目的。在粉色服务生制服的包裹下，莓香以端坐的姿势登场，充满大小姐的典雅与温柔。此外，莓香微微上扬的嘴角充满可爱气质，而那个经典的抖S表情则需要在Aniplex官方店铺购买手办才能获取。据悉，Aniplex樱之宫莓香1/8比例手办将于2018年10月开始发售，含税售价12000日元（约合人民币690元）。', '201712', 'http://img1.gamersky.com/image2017/12/20171226_sy_225_5/gamersky_04small_08_201712261033A0C.jpg', 'http://acg.gamersky.com/otaku/zb/201712/995079.shtml');
INSERT INTO `news` VALUES (995256, '《FGO》尼禄浴衣手办开启预订 娇小暴君展露好身材', '《FGO》推出各个角色手办的速度绝对一流，而且很多都是已经成为系列，其中的浴衣系列在推出了贞德和马修之后，尼禄的浴衣手办也将在今天（12月26日）开始预订，官方放出了尼禄浴衣手办的图片，身着粉色浴衣的尼禄显得格外活波，而且这身浴衣也将她的身材很好的衬托出来，身材娇小但却十足有料啊。FREEING《Fate/Grand Order》尼禄浴衣手办于12月26日开定，全高约22cm，售价8800日元(约为人民币510元)，预计2018年5月正式发售。浴衣三人组放到一起还是相当不错的，不考虑收一组吗？', '201712', 'http://img1.gamersky.com/image2017/12/20171226_lr_176_3/gamersky_01small_02_201712261431154.jpg', 'http://acg.gamersky.com/otaku/zb/201712/995256.shtml');
INSERT INTO `news` VALUES (995682, '手机游戏《甲铁城的卡巴内瑞》无名新款浴衣手办开启众筹 目标12万元', '《甲铁城的卡巴内瑞》女主角无名因其可爱而潇洒的形象深入人心，近日一款无名身穿浴衣的手办在京东开启众筹活动，目标数额为12万元人民币。本款无名浴衣手办由《甲铁城的卡巴内瑞》手游运营方盖娅互娱，以及中国原创手办生产商末那工作室合作打造，众筹活动已于12月底开启。其中萝莉无名身穿可爱浴衣，指尖勾起木屐的姿态格外令人垂涎。细节方面，制作者在浴衣的花饰、剑玉的做工、口中的吹笛和大腿皮肤的光洁程度等方面大费文章，尽可能呈现出无名的可爱之处。目前这项众筹活动已经获得了7750元人民币的数额，支持者为20人。根据介绍，本项目必须在2018年2月23日之前筹措到12万人民币才可计为成功，目前距离截止日期还剩58天。此外，按照捐款档次，募资28元的支持者可以获赠无名战斗服钥匙链（两款二选一），48元可以获得全两款钥匙链，而捐款498元的顾客则能够免运费得到本款浴衣版手办和价值300元的手游大礼包，以上赠品将在众筹成功后三至五个月之内发送。', '201712', 'http://img1.gamersky.com/image2017/12/20171227_sy_225_10/gamersky_01small_02_2017122714137A9.jpg', 'http://acg.gamersky.com/otaku/zb/201712/995682.shtml');
INSERT INTO `news` VALUES (997487, '《Fate/Grand Order》玛修新年礼服手办 可爱学妹风情满满庆新年', '《Fate/Grand Order》中的玛修非常受到大家的欢迎，这个有点天然呆的妹子有着让人唏嘘的身世，但是一切似乎都不能阻止她对外面世界的向往。今天是2018年的第一天，手办厂商也是很应景的推出了玛修的新年礼服手办，将玛修穿着新年礼服的样子完美的展现出来，色彩鲜艳的和服以及小清新的百合头饰使玛修显得更加活泼可爱。这款《FGO》玛修新年礼服手办高约280mm，售价为15400日元（约为人民币889元）。手办已经在今天（1月1日）开始预订，将于2018年正式发售，学妹的粉丝们可不要错过了。', '201801', 'http://img1.gamersky.com/image2018/01/20180101_lr_176_5/gamersky_01small_02_2018111527854.jpg', 'http://acg.gamersky.com/otaku/zb/201801/997487.shtml');
INSERT INTO `news` VALUES (999775, '第一名火了大半年 外媒评2017年十佳PC游戏', '外媒Techradar发布了他们心目中2017年最佳PC游戏排名。2017年是游戏业最佳的一年，现在又到了评选2017年最佳PC游戏的时候了。需要注意的是，这些游戏排名并不具有绝对代表性，只是一家之观点，并不代表所有人的观点。大家也可以在文章下方讨论你们心目中2017年最佳PC游戏。\r\n\r\n　　不管你是RPG死忠玩家，还是FPS高端玩家，或者独立游戏信徒，2017年的游戏都满足了你们的需求。现在来一起看看有哪些PC游戏进入了2017年10佳游戏排名。\r\n\r\n1.《绝地求生》\r\n\r\n　　你们觉得我们的2017年最佳PC游戏列表没有《绝地求生》吗?当然是不可能的。其他游戏连《绝地求生》的车尾灯都看不到。\r\n\r\n　　这款游戏的火爆让很多游戏主播也火了起来，“大吉大利，今晚吃鸡”这句话也深入世界上每个玩家的内心。2.《命运2》\r\n\r\n　　尽管这款游戏的操控体验问题有些影响游戏评分，但这款游戏在初代的基础上，各个方面都有了提升。\r\n\r\n　　海量的剧情让故事丰富，组队匹配也得到改善，开始游戏更容易，游戏的新模式趋向守望先锋式玩法，这些都反映出Bungie(开发商)愿意听粉丝的心声。\r\n\r\n　　随着更多DLC的发布，更多更新内容和活动，《命运2》还会一直火下去。', '201801', 'http://img1.gamersky.com/image2017/12/20171208_djy_248_3/gamersky_01origin_01_20171281527366.jpg', 'http://www.gamersky.com/wenku/201801/999775.shtml');
INSERT INTO `news` VALUES (999782, '《星际争霸2》WCS 2018欧洲资格赛官方分组出错 选手被迫重赛', '《星际争霸2》WCS 2018随着莱比锡欧洲资格赛的开始早早地拉开了帷幕，不过比赛刚开始30分钟就被迫重赛，原因让人有些无语。比赛进行的过程中，一名选手注意到选手分组是不正确的，而且已经有一场开始比了，但没有在场工作人员去解决这个问题，这让事情更加糟糕。比赛的选手分组有严格的规则，首先8个选手分为2组，然后根据其WCS点数（2017年的）来排名，然后再分组，最终分成如下：\r\n\r\n　　Pool 1A: Elazer, Serral\r\n\r\n　　Pool 1B: Nerchio, uThermal\r\n\r\n　　Pool 2A: Snute, Stephano\r\n\r\n　　Pool 2B: Harstem, Bly\r\n\r\n　　分完之后再随即匹配进行比赛，比如说1A组的Serral对战2B组任意一位选手。不过如果之前两个选手曾交手过，那么在第一轮中就不应该再匹配到。然而最初的这个分组选手池就存在一些错误，Elazer 和Stephano打过，uThermal和Harstem打过，那按照上面的规则随机到了就是错误的。最后得出的方案是有几个选手不得不重赛一次。\r\n\r\n　　这其中受到影响最大的是选手Serral，他本来已经取得资格赛的胜利，但现在不得不重新比一次了。', '201801', 'http://img1.gamersky.com/image2018/01/20180108_gd_340_4/gamersky_02origin_03_2018181125AC0.jpg', 'http://ol.gamersky.com/news/201801/999782.shtml');
INSERT INTO `news` VALUES (999885, '《怪物猎人：世界》新截图 众多大佬级怪物登场', '卡普空的《怪物猎人：世界》将在今年1月26日发售，在不久前的新宣传片中，我们见到了风翔龙、炎王龙河飞雷龙等霸气怪物，而最近官方发布了游戏的高清新截图，则展示了更多的“大佬级别”怪物。\r\n\r\n　　炎王龙拥有炽热的吐息，浑身缠绕着烈焰凶猛无比，这头古龙性情非常火爆，敢正面与其对峙的人都会被烈焰所焚灭。钢龙拥有坚硬的金属外壳，常人难以近身，它的庞大翅膀能令其像一阵风暴般飞过。岩贼龙，它主要以岩石为食，而且能通过体内的特殊构造令唾液与岩石结合，变成拥有杀伤力的爆炸武器，通过吐出来攻击敌人。之前我们了解到，在今年春季《怪物猎人：世界》会免费更新“恐暴龙”狩猎任务，新截图中展示的恐暴龙依旧是经典造型，血盆大口令人胆寒。此外，有日本网友晒图爆料称，PS4《怪物猎人：世界》需求硬盘容量可能达到了16GB以上。游戏将在今年1月19日至22日官方将开启第三次测试。', '201801', 'http://img1.gamersky.com/image2018/01/20180108_wyc_246_7/gamersky_01small_02_201818113950A.jpg', 'http://www.gamersky.com/news/201801/999885.shtml');
INSERT INTO `news` VALUES (999910, 'AMD确认第二代Ryzen处理器2018年4月发布 12nm工艺制程', '今日，AMD确认将会在今年4月份发布第二代Ryzen处理器，据悉全新的处理器将会采用12nm工艺制程，拥有更高的频率，同时还搭载更先进的Boost 2.0。在2017年上半年，AMD推出了第一代Ryzen 7，在处理器市场掀起了一阵波澜，也成功让AMD在处理器领域再次崛起。而第二代Ryzen处理器之前有消息称会在今年早些时候推出，现在看来刚好与官方4月份推出的消息重合。此外，AMD还确认X470主板将会和第二代Ryzen处理器一起推出，另外第二代“线程撕裂者”处理器将会在2018年下半年正式发布。', '201801', 'http://img1.gamersky.com/image2018/01/20180108_wyc_246_9/gamersky_04small_08_201818123128.jpg', 'http://www.gamersky.com/tech/201801/999910.shtml');
INSERT INTO `news` VALUES (999935, '粉丝自制《战神》新作奎爷战斧 霸气外观官方点赞c', '虽然PS4《战神》新作还未公布具体发售日，但我们都知道奎爷父子已经离我们越来越近了，与他们一起在北欧大地上的冒险即将展开。\r\n\r\n　　而最近，推特上一位粉丝@TheRealHades 将《战神》新作中奎爷的利维坦战斧给打造了出来，圣莫尼卡制作组看到后欣喜不已，特地转推点赞了一番。据悉，这把战斧是由3D打印制造而成，所以它并不是用实木和铁斧做成的，不过制作者对细节的把握十分到位，即便材质是泡沫塑料，也能呈现出霸气的外观。此外制作者还表示，未来他会在上面增加LED灯饰，好还原游戏中斧子的符文形态。《战神》新作预计将于今年年初发售，登陆PS4平台，敬请期待。', '201801', 'http://img1.gamersky.com/image2018/01/20180108_wyc_246_10/gamersky_02small_04_2018181223121.jpg', 'http://www.gamersky.com/news/201801/999935.shtml');
INSERT INTO `news` VALUES (999942, '《绝地求生》Steam老玩家可免费回归国服：每个帐号仅能绑定1个QQ 战绩不同步', '《绝地求生》国服通过客服回答了一些玩家们关心的问题，比如Steam老玩家最在意的回归问题。在《老兵回归活动规则》中，官方表示1月5日早上6：00之前在steam《绝地求生》创建角色的玩家，可绑定QQ号和steam账号，登记老兵身份，享受回归服务，老兵可无门槛免费登录国服。 ​​​​​​​​在腾讯客服的介绍说明中，官方表示，每个steam账号仅可与一个QQ号绑定，也可以解绑，但在绑定后24小时内不能解绑，steam账号的战绩不会同步也不会更新到国服。 ​​​​\r\n\r\n以下是老兵回归活动介绍说明：\r\n\r\n　　Q: 成功绑定账号后，什么时候可以登录国服？\r\n\r\n　　A：在国服不限号开启后，所有老兵即可无门槛登录国服。您也可以通过官方放号活动报名参与技术测试，抢先体验。', '201801', 'http://img1.gamersky.com/image2018/01/20180105_gd_340_6/gamersky_02origin_03_201815169AA8.jpg', 'http://www.gamersky.com/news/201801/999291.shtml');
INSERT INTO `news` VALUES (999947, 'Intel推出历代最强NUC迷你电脑 搭载最新联合处理器', 'Intel正式推出首款搭载 Radeon RX Vega M显卡的第八代智能英特尔酷睿处理器，可有效满足游戏玩家、内容创建者、以及虚拟混合现实爱好者的需求。全新的第八代智能英特尔Core处理器共有两个规格，分别是搭载Radeon RX Vega M GL显卡的第八代Intel Core处理器（65W TDP）；搭载Radeon RX Vega M GH 显卡的第八代Intel Core处理器（100W TDP），采用未锁频配置。\r\n\r\n　　与此同时Intel还推出基于全新处理器的两款NUC迷你电脑。Intel表示这两款NUC迷你电脑将会是史上性能最强大的NUC电脑。全新的NUC迷你电脑共有两个型号，分别是NUC8i7HVK和NUC8i7HNK。\r\n\r\n　　NUC8i7HVK搭载包含Radeon RX Vega M GH显卡的全新第八代智能英特尔酷睿处理器的未锁频版，让超频爱好者能够进一步提升系统性能。NUC8i7HNK搭载包含Radeon RX Vega M GL显卡的第八代智能英特尔酷睿处理器。\r\n\r\n　　此外NUC迷你电脑还拥有两个“雷电3”接口，两个千兆网端口，最多支持六个显示器。\r\n\r\n　　Intel称这两款迷你电脑的售价为799美元和999美元。', '201801', 'http://img1.gamersky.com/image2018/01/20180108_gd_340_6/gamersky_01origin_01_2018181359CA1.jpg', 'http://www.gamersky.com/tech/201801/999947.shtml');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `id` int(8) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `tel` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `username`(`username`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 10 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES (1, 'king', 'qhappy', '123', '123@qq.com');
INSERT INTO `user` VALUES (8, '123', '123', '123', '123');
INSERT INTO `user` VALUES (9, 'admin', '123', '123', '123@qq.com');

SET FOREIGN_KEY_CHECKS = 1;
