"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
exports.__esModule = true;
exports.HomeAdminComponent = void 0;
var core_1 = require("@angular/core");
var User_1 = require("../../Models/Auth/User");
var Roles_1 = require("../../Models/Auth/Roles");
var Links_1 = require("../../Models/Main_models/Links");
var links_service_1 = require("../../Services/links/links.service");
var About_1 = require("../../Models/Main_models/About");
var about_service_1 = require("../../Services/about/about.service");
var $ = require("jquery");
var HomeAdminComponent = /** @class */ (function () {
    function HomeAdminComponent(titleService, authService, linkService, aboutService) {
        var _this = this;
        this.titleService = titleService;
        this.authService = authService;
        this.linkService = linkService;
        this.aboutService = aboutService;
        this.isExpanded = false;
        this.userData = new User_1.User();
        this.userRole = Roles_1.UserRole;
        this.link = new Links_1.Links();
        this.about = new About_1.About();
        this.userDataSubscription = this.authService.userData.asObservable().subscribe(function (data) {
            _this.userData = data;
        });
    }
    HomeAdminComponent.prototype.loadLinks = function () {
        var _this = this;
        this.linkService.getLinks()
            .subscribe(function (data) { return _this.links = data; });
    };
    HomeAdminComponent.prototype.loadAbouts = function () {
        var _this = this;
        this.aboutService.getAbouts()
            .subscribe(function (data) { return _this.abouts = data; });
    };
    HomeAdminComponent.prototype.ngOnInit = function () {
        this.titleService.setTitle('Home Admin');
        this.loadLinks();
        this.loadAbouts();
        // Add active state to sidbar nav links
        var path = window.location.href; // because the 'href' property of the DOM element is the absolute path
        $('#layoutSidenav_nav .sb-sidenav a.nav-link').each(function () {
            if (this.href === path) {
                $(this).addClass('active');
            }
        });
        // Toggle the side navigation
        $('#sidebarToggle').on('click', function (e) {
            e.preventDefault();
            $('body').toggleClass('sb-sidenav-toggled');
        });
    };
    HomeAdminComponent.prototype.logout = function () {
        this.authService.logout();
    };
    HomeAdminComponent = __decorate([
        core_1.Component({
            selector: 'app-home-admin',
            templateUrl: './home-admin.component.html',
            styleUrls: ['./home-admin.component.css'],
            providers: [links_service_1.LinksService, about_service_1.AboutService]
        })
    ], HomeAdminComponent);
    return HomeAdminComponent;
}());
exports.HomeAdminComponent = HomeAdminComponent;
