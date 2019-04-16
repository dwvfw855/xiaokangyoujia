/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : lifeserver

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2019-04-16 10:41:10
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for module_homechildren
-- ----------------------------
DROP TABLE IF EXISTS `module_homechildren`;
CREATE TABLE `module_homechildren` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `mainID` int(11) DEFAULT NULL,
  `ChildrenMenuID` int(11) DEFAULT NULL,
  `ChildrenMenuName` varchar(255) DEFAULT NULL,
  `ChildrenMenuImgUrl` varchar(255) DEFAULT NULL,
  `ChildrenMenuUrl` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of module_homechildren
-- ----------------------------
INSERT INTO `module_homechildren` VALUES ('1', '1', null, '积分商城', '/images/1.png', 'Integral/MainShop');
INSERT INTO `module_homechildren` VALUES ('2', '1', null, '影音天地', '/images/2.png', 'index.html');
INSERT INTO `module_homechildren` VALUES ('3', '1', null, '生日专区', '/images/3.png', 'index.html');
INSERT INTO `module_homechildren` VALUES ('4', '1', null, '果园飘香', '/images/4.png', 'index.html');
INSERT INTO `module_homechildren` VALUES ('5', '1', null, '关爱健康', '/images/5.png', 'index.html');
INSERT INTO `module_homechildren` VALUES ('6', '1', null, '应季甄选', '/images/6.png', 'index.html');
INSERT INTO `module_homechildren` VALUES ('7', '1', null, '轻松出行', '/images/7.png', 'index.html');
INSERT INTO `module_homechildren` VALUES ('8', '1', null, '景点门票', '/images/8.png', 'index.html');

-- ----------------------------
-- Table structure for module_main
-- ----------------------------
DROP TABLE IF EXISTS `module_main`;
CREATE TABLE `module_main` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ModuleName` varchar(255) DEFAULT NULL COMMENT '模块名称',
  `ModuleUrl` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of module_main
-- ----------------------------
INSERT INTO `module_main` VALUES ('1', '首页', 'index.html');
INSERT INTO `module_main` VALUES ('2', '订单中心', 'index.html');
INSERT INTO `module_main` VALUES ('3', '个人中心', 'index.html');

-- ----------------------------
-- Table structure for module_relationformain
-- ----------------------------
DROP TABLE IF EXISTS `module_relationformain`;
CREATE TABLE `module_relationformain` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ModuleId` int(11) DEFAULT NULL,
  `ModulechildenName` varchar(255) DEFAULT NULL COMMENT '子模块名称',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of module_relationformain
-- ----------------------------
INSERT INTO `module_relationformain` VALUES ('1', '1', '家电清洗');
INSERT INTO `module_relationformain` VALUES ('2', '1', '清洗套餐');
INSERT INTO `module_relationformain` VALUES ('3', '1', '居家换新');
INSERT INTO `module_relationformain` VALUES ('4', '1', '健康生活');

-- ----------------------------
-- Table structure for shop_detail
-- ----------------------------
DROP TABLE IF EXISTS `shop_detail`;
CREATE TABLE `shop_detail` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OrderListID` int(11) DEFAULT NULL,
  `detailContent` text,
  `detailSpecifications` longtext,
  `MainGUID` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_detail
-- ----------------------------
INSERT INTO `shop_detail` VALUES ('2', '1', '<div class=\"name_box \" style=\"display: none;\">\r\n						<img src=\"images/xqq/sp_2.png\">\r\n						<img src=\"images/xqq/sp_1.png\">\r\n					</div>', '<div class=\"name_box detail_width_con\" style=\"display: block;\">\r\n						<span class=\"detail_main\">品牌及名称：海尔变频空调海尔变频空调</span>\r\n						<span class=\"detail_main\">型号：AB-DCN03</span>\r\n						<span class=\"detail_main\">规格：280x308x292</span>\r\n						<span class=\"detail_main\">材质：钢化模型</span>\r\n						<span class=\"detail_main\">产地：上海</span>\r\n						<span class=\"detail_main\">配送时间：我们会在您下单后的2-3个工作日内日发货</span>\r\n					</div>', null);

-- ----------------------------
-- Table structure for shop_orderlist
-- ----------------------------
DROP TABLE IF EXISTS `shop_orderlist`;
CREATE TABLE `shop_orderlist` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ShopName` varchar(255) DEFAULT NULL,
  `ShopMoney` varchar(255) DEFAULT NULL,
  `ShopMoneyInteGral` varchar(255) DEFAULT NULL,
  `ZHID` varchar(255) DEFAULT NULL,
  `ShopType` varchar(255) DEFAULT NULL,
  `OrderImgUrl` varchar(255) DEFAULT NULL,
  `CeateTime` varchar(255) DEFAULT NULL,
  `GUID` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_orderlist
-- ----------------------------
INSERT INTO `shop_orderlist` VALUES ('1', '迷你智能电饭煲', '100', '100', null, '3', 'images/jifen/sp.png', null, null);
INSERT INTO `shop_orderlist` VALUES ('2', '迷你智能电饭煲', '100', '100', '', '3', 'images/jifen/sp.png', null, null);
INSERT INTO `shop_orderlist` VALUES ('3', '迷你智能电饭煲', '100', '100', null, '3', 'images/jifen/sp.png', null, null);
INSERT INTO `shop_orderlist` VALUES ('4', null, '100', null, null, '3', 'images/jifen/sp.png', '2019/4/16 10:28:16', '00000000000000000000000000000000');
INSERT INTO `shop_orderlist` VALUES ('5', '测试商品', '100', null, null, '3', 'images/jifen/sp.png', '2019/4/16 10:30:19', '00000000000000000000000000000000');
INSERT INTO `shop_orderlist` VALUES ('6', '测试商品', '100', null, null, '3', 'images/jifen/sp.png', '2019/4/16 10:31:23', 'e44d0d28eb3e4057a43ac050ed6fb064');

-- ----------------------------
-- Table structure for shop_type
-- ----------------------------
DROP TABLE IF EXISTS `shop_type`;
CREATE TABLE `shop_type` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(255) DEFAULT NULL COMMENT '商品类型',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_type
-- ----------------------------
INSERT INTO `shop_type` VALUES ('1', '美容');
INSERT INTO `shop_type` VALUES ('2', '电子');
INSERT INTO `shop_type` VALUES ('3', '家居');
INSERT INTO `shop_type` VALUES ('4', '美食');
INSERT INTO `shop_type` VALUES ('5', '服饰');
INSERT INTO `shop_type` VALUES ('6', '母婴');
INSERT INTO `shop_type` VALUES ('7', '运动');

-- ----------------------------
-- Table structure for user_maininfo
-- ----------------------------
DROP TABLE IF EXISTS `user_maininfo`;
CREATE TABLE `user_maininfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL COMMENT '姓名',
  `Sex` varchar(255) DEFAULT NULL COMMENT '性别',
  `Guid` varchar(255) DEFAULT NULL,
  `Phone` varchar(255) DEFAULT NULL,
  `Adress` varchar(255) DEFAULT NULL,
  `InvitationCode` varchar(255) DEFAULT NULL COMMENT '邀请码',
  `Type` varchar(255) DEFAULT NULL COMMENT '用户类型',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user_maininfo
-- ----------------------------
