from django.urls import path
from .views import UsersView

from . import views

urlpatterns = [
    #path("", views.index, name="index"),
    path('api-view', UsersView.as_view(), name='users'),
]
