// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(document).ready(function () {
	jQuery('head').ready(function () {
		//$('.newbut').ajaxForm(function () {
		//	success: function() {
		//		alert("SUCCESS!");
		//		window.location.href = "/Index1";
		//	}
		//});
		$(".title").click(function () {
			$(".title").animate({ top: "+=20" }, 1500)
				.animate({ top: "-=20" }, 1500, arguments.callee)
			return false;
		});
		$(".push").click(function () {
			$("p").hide(2000);
			$("img").show(2000);
		})
		$(".in").click(function () {
			$("p").show(2000);
			$("img").hide(1000);
		})
		setTimeout(function () {
			$(".title").trigger("click");
		}, 1);

		$(".MarsFirst").click(function () {
			$("p").hide(10);
		})
		$(".MarsFirst").click(function () {
			$("p").fadeIn(2000);
		})
		$(".MarsFirst").click(function () {
			$(".first").animate({ top: "+=470" }, 1500)
				.animate({ top: "-=470" }, 1500, arguments.callee)
			return false;
		});
		$(".MarsFirst").click(function () {
			$(".second").animate({ top: "+=470" }, 1500)
				.animate({ top: "-=470" }, 1500, arguments.callee)
			return false;
		});
		setTimeout(function () {
			$(".MarsFirst").trigger("click");
		}, 1);

		$(".newbut").click(function () {
			alert("ACCESSED");

		})

	})
})