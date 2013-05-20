ko.bindingHandlers.clickoutside = {
	init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
		$(element).bind('clickoutside', function () {
			if ((valueAccessor())()) {
				(valueAccessor())(false);
			}
		});
	},
	update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
	}
};